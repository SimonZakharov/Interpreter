using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Interpreter
{
    public abstract class Rule
    {
        public string Name {get; set;}
        public List<Rule> Children = new List<Rule>();
        public abstract string Definition
        {
            get;
        }

        public Rule(IEnumerable<Rule> rules) {
            if (rules.Any(r => r == null)) throw new Exception("No child rule can be null");
            Children = new List<Rule>(rules);
        }

        public Rule(params Rule[] rules) : this((IEnumerable<Rule>) rules)
        {
        }

        public Rule Child
        {
            get
            {
                return Children[0];
            }
        }

        protected abstract bool InternalMatch(ParserState state);

        public bool Match(ParserState state)
        {
            // HINT: this is a good place to put a conditional breakpoint when debugging, using the Name = X as a condition
            return InternalMatch(state);
        }

        public bool Match(string input)
        {
            var state = new ParserState() { input = input, position = 0 };
            return Match(state);
        }

        public static Rule operator +(Rule r1, Rule r2)
        {
            return Grammar.Seq(r1, r2);
        }

        public static Rule operator |(Rule r1, Rule r2)
        {
            return Grammar.Choice(r1, r2);
        }

        public Rule SetName(string s)
        {
            Name = s;
            return this;
        }

        public List<Node> Parse(string input)
        {
            var state = new ParserState() { input = input, position = 0 };
            if (!Match(state))
                throw new Exception(String.Format("Rule {0} failed to match", Name));
            return state.nodes;
        }

        public override string ToString()
        {
            return Name ?? Definition;
        }
    }

    public class AtRule : Rule
    {
        public AtRule(Rule rule)
            : base(rule)
        {
        }

        protected override bool InternalMatch(ParserState state)
        {
            var old = state.Clone();
            bool result = Child.Match(state);
            state.Assign(old);
            return result;
        }

        public override string Definition
        {
            get { return String.Format("At({0})", Child.ToString()); }
        }
    }

    public class NotRule : Rule
    {
        public NotRule(Rule rule)
            : base(rule)
        {
        }

        protected override bool InternalMatch(ParserState state)
        {
            var old = state.Clone();
            if (Child.Match(state))
            {
                state.Assign(old);
                return false;
            }
            return true;
        }

        public override string Definition
        {
            get { return String.Format("Not({0})", Child.ToString()); }
        }
    }

    public class NodeRule : Rule
    {
        private static readonly bool UseCache = true;

        public NodeRule(Rule rule)
            : base(rule)
        {
        }

        protected override bool InternalMatch(ParserState state)
        {
            try
            {
                if (UseCache)
                    return InternalMatchWithCache(state);
                else
                    return InternalMatchWithOutCache(state);
            }
            catch (Exception e)
            {
                Console.WriteLine("While parsing rule {0} occured an error: {1}", Name, e.Message);
                throw;
            }
        }

        private bool InternalMatchWithCache(ParserState state)
        {
            Node node;
            int start = state.position;
            if (state.GetCachedResult(this, out node))
            {
                if (node == null) return false;
                state.position = node.End;
                state.nodes.Add(node);
                return true;
            }
            node = new Node(state.position, Name, state.input);
            var oldNodes = state.nodes;
            state.nodes = new List<Node>();
            if (Child.Match(state))
            {
                node.End = state.position;
                node.nodes = state.nodes;
                oldNodes.Add(node);
                state.nodes = oldNodes;
                state.CacheResult(this, start, node);
                return true;
            }
            else
            {
                state.nodes = oldNodes;
                state.CacheResult(this, start, null);
                return false;
            }
        }

        private bool InternalMatchWithOutCache(ParserState state)
        {
            Node node = new Node(state.position, Name, state.input);
            var oldNodes = state.nodes;
            state.nodes = new List<Node>();
            if (Child.Match(state))
            {
                node.End = state.position;
                node.nodes = state.nodes;
                oldNodes.Add(node);
                state.nodes = oldNodes;
                return true;
            }
            else
            {
                state.nodes = oldNodes;
                return false;
            }
        }

        public override string Definition
        {
            get { return Child.Definition; }
        }
    }

    public class RecursiveRule : Rule
    {
        Func<Rule> ruleGen;

        public RecursiveRule(Func<Rule> ruleGen)
        {
            this.ruleGen = ruleGen;
        }

        protected override bool InternalMatch(ParserState state)
        {
            if (Children.Count == 0)
                Children.Add(ruleGen());
            return Child.Match(state);
        }

        public override string ToString()
        {
            return Name ?? (Children.Count > 0 ? Children[0].ToString() : "recursive");
        }

        public override string Definition
        {
            get { return ruleGen().Definition; }
        }
    }

    public class ChoiceRule : Rule
    {
        public ChoiceRule(params Rule [] rs)
            : base(rs)
        {
        }

        protected override bool InternalMatch(ParserState state)
        {
            var old = state.Clone();
            foreach (var c in Children)
            {
                if (c.Match(state)) return true;
                state.Assign(old);
            }
            return false;
        }

        public override string Definition
        {
            get 
            {
                var sb = new StringBuilder();
                sb.Append(Children[0].ToString());
                if (Children.Count == 2 && Children[1] is ChoiceRule)
                {
                    sb.Append(" | "); sb.Append(Children[1].Definition);
                }
                else {
                    for (int i = 1; i < Children.Count; i++)
                    {
                        sb.Append(" | ").Append(Children[i].ToString());
                    }
                }
                return sb.ToString();
            }
        }

        public override string ToString()
        {
            return String.Format("({0})", base.ToString());
        }
    }

    public class SeqRule : Rule
    {
        public SeqRule(params Rule[] rs)
            : base(rs)
        {
        }

        protected override bool InternalMatch(ParserState state)
        {
            var old = state.Clone();
            foreach (var n in Children) {
                if (!n.Match(state))
                {
                    state.Assign(old);
                    return false;
                }
            }
            return true;
        }

        public override string Definition
        {
            get 
            {
                var sb = new StringBuilder();
                sb.Append(Children[0].ToString());
                if (Children.Count == 2 && Children[1] is SeqRule)
                {
                    sb.Append(" + ");
                    sb.Append(Children[1].Definition);
                }
                else
                {
                    for (int i = 1; i < Children.Count; i++)
                    {
                        sb.Append(" + ").Append(Children[i].ToString());
                    }
                }
                return sb.ToString();
            }
        }

        public override string ToString()
        {
            return String.Format("({0})", base.ToString());
        }
    }

    public class EndRule : Rule
    {
        protected override bool InternalMatch(ParserState state)
        {
            return state.position == state.input.Length;
        }

        public override string Definition
        {
            get
            {
                return String.Format("_EOF_");
            }
        }
    }

    public class ZeroOrMoreRule : Rule
    {
        public ZeroOrMoreRule(Rule rule)
            : base(rule)
        {
        }

        protected override bool InternalMatch(ParserState state)
        {
            while (Child.Match(state)) { }; return true;
        }

        public override string Definition
        {
            get { return String.Format("{0}*", Child.ToString()); }
        }
    }

    public class PlusPule : Rule
    {
        public PlusPule(Rule rule)
            : base(rule)
        {
        }

        protected override bool InternalMatch(ParserState state)
        {
            if (!Child.Match(state)) return false;
            while (Child.Match(state)) { }
            return true;
        }

        public override string Definition
        {
            get { return String.Format("{0}+", Child.ToString()); }
        }
    }

    public class OptRule : Rule
    {
        public OptRule(Rule rule)
            : base(rule)
        {
        }

        protected override bool InternalMatch(ParserState state)
        {
            Child.Match(state); return true;
        }

        public override string Definition
        {
            get { return String.Format("{0}?", Child.ToString()); }
        }
    }

    public class StringRule : Rule
    {
        string s;

        public StringRule(string s)
        {
            this.s = s;
        }

        protected override bool InternalMatch(ParserState state)
        {
            if (!state.input.Substring(state.position).StartsWith(s)) return false;
            state.position += s.Length;
            return true;
        }

        public override string Definition
        {
            get { return String.Format(""); }
        }
    }

    public class CharRule : Rule
    {
        Predicate<char> predicate;

        public CharRule(Predicate<char> p)
        {
            predicate = p;
        }

        protected override bool InternalMatch(ParserState state)
        {
            if (state.position > state.input.Length) return false;
            if (!predicate(state.input[state.position])) return false;
            state.position++;
            return true;
        }

        public override string Definition
        {
            get { return "f(char)"; }
        }
    }

    public class RegexRule : Rule
    {
        Regex regex;

        public RegexRule(Regex re)
        {
            this.regex = re;
        }

        protected override bool InternalMatch(ParserState state)
        {
            var m = regex.Match(state.input, state.position);
            if (m == null || m.Index != state.position) return false;
            state.position += m.Length;
            return true;
        }

        public override string Definition
        {
            get { return String.Format("regex({0})", regex.ToString()); }
        }
    }
}
