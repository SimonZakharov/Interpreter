using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Interpreter
{
    public class Grammar
    {
        /// <summary>
        /// This rule should be used with a named rule only, since the name of the rule is used as a label
        /// </summary>
        /// <param name="rule"></param>
        /// <returns></returns>
        public static Rule Node(Rule rule)
        {
            return new NodeRule(rule);
        }

        /// <summary>
        /// This creates a rule that can recursively refer to itself, directly or indirectly
        /// </summary>
        /// <param name="ruleGen"></param>
        /// <returns></returns>
        public static Rule Recursive(Func<Rule> ruleGen)
        {
            return new RecursiveRule(ruleGen);
        }

        public static Rule Seq(params Rule [] rs)
        {
            return new SeqRule(rs);
        }

        public static Rule Choice(params Rule[] rs)
        {
            return new ChoiceRule(rs);
        }

        public static Rule At(Rule r)
        {
            return new AtRule(r);
        }

        public static Rule Not(Rule r)
        {
            return new NotRule(r);
        }

        public static Rule ZeroOrMore(Rule r)
        {
            return new ZeroOrMoreRule(r);
        }

        public static Rule OneOrMore(Rule r)
        {
            return new PlusPule(r);
        }

        public static Rule Opt(Rule r)
        {
            return new OptRule(r);
        }

        public static Rule MatchChar(Predicate<char> predicate)
        {
            return new CharRule(predicate);
        }

        public static Rule MatchChar(char c)
        {
            return MatchChar(x => x == c).SetName(c.ToString());
        }

        public static Rule MatchString(string s)
        {
            return new StringRule(s);
        }

        public static Rule MatchRegex(Regex r)
        {
            return new RegexRule(r);
        }

        public static Rule End = new EndRule();

        public static Rule CharSet(string s)
        {
            if (String.IsNullOrEmpty(s)) throw new ArgumentException("Unexpected null string");
            return MatchChar(c => s.Contains(c)).SetName(String.Format("[{0}]", s));
        }

        public static Rule CharRange(char a, char b)
        {
            return MatchChar(c => (c >= a) && (c <= b)).SetName(String.Format("[{0}..{1}]", a, b));
        }

        public static Rule ExceptCharSet(string s)
        {
            if (String.IsNullOrEmpty(s)) throw new ArgumentException("Unexpected null string");
            return MatchChar(c => !s.Contains(c)).SetName(String.Format("[{0}]", s));
        }

        public static Rule AnyChar = MatchChar(c => true).SetName(".");

        public static Rule AdvanceWhileNot(Rule r)
        {
            if (r == null) throw new ArgumentNullException("Unexpected null rule");
            return ZeroOrMore(Seq(Not(r), AnyChar));
        }

        public static Rule Pattern(string s)
        {
            if (String.IsNullOrEmpty(s)) throw new ArgumentException("Unexpected null string");
            return MatchRegex(new Regex(s));
        }

        public static IEnumerable<Rule> GetRules(Type type)
        {
            foreach (var field in type.GetFields())
            {
                if (field.FieldType.Equals(typeof(Rule)))
                    yield return (Rule)field.GetValue(null);
            }
        }

        /// <summary>
        /// Provides a name to all fields of type Rule
        /// </summary>
        /// <param name="type"></param>
        public static void InitGrammar(Type type)
        {
            foreach (var field in type.GetFields())
            {
                if (field.FieldType.Equals(typeof(Rule)))
                {
                    var rule = field.GetValue(null) as Rule;
                    if (rule == null)
                        throw new Exception("Unexpected null rule");
                    rule.Name = field.Name;
                }
            }
        }

        public static void OutputGrammar(Type type, TextWriter tw)
        {
            foreach (var t in GetRules(type))
            {
                tw.WriteLine("{0} <- {1}", t.Name, t.Definition);
            }
        }

        public static void OutputGrammar(Type type)
        {
            foreach (var t in GetRules(type))
                Console.WriteLine("{0} <- {1}", t.Name, t.Definition);
        }
    }
}
