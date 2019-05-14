using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Interpreter
{
    public class ParserState
    {
        public string input;
        public int position;
        public List<Node> nodes = new List<Node>();
        public Dictionary<int, Dictionary<Rule, Node>> cache = new Dictionary<int, Dictionary<Rule, Node>>();

        public string Current
        {
            get
            {
                return input.Substring(position);
            }
        }

        public ParserState Clone()
        {
            return new ParserState {
                input = input, position = position, nodes = new List<Node>(nodes)
            };
        }

        public void Assign(ParserState state)
        {
            input = state.input; position = state.position; nodes = state.nodes;
        }

        public void RestoreAfter()
        {
            var state = Clone();
            Assign(state);
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", position, input.Length);
        }

        public void CacheResult(Rule rule, int pos, Node node)
        {
            if (!cache.ContainsKey(pos))
                cache.Add(pos, new Dictionary<Rule,Node>());
            var temp = cache[pos];
            if (!temp.ContainsKey(rule))
                temp.Add(rule, node);
        }

        public bool GetCachedResult(NodeRule rule, out Node node)
        {
            node = null;
            if (!cache.ContainsKey(position))
                return false;
            if (cache[position].ContainsKey(rule))
            {
                node = cache[position][rule];
                return true;
            }
            return false;
        }
    }
}
