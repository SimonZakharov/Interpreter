using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Dynamic;

namespace Interpreter
{
    public class Node
    {
        public string Input;
        public int Begin;
        public int End;
        /// <summary>
        /// name of the associated rule
        /// </summary>
        public string Label;
        public List<Node> nodes = new List<Node>();

        /// <summary>
        /// Default constructor
        /// </summary>
        public Node()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="label"></param>
        /// <param name="input"></param>
        public Node(int begin, string label, string input)
        {
            if (label == null)
                throw new ArgumentNullException();
            Begin = begin; Label = label; Input = input;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="label"></param>
        /// <param name="content"></param>
        public Node(string label, IEnumerable<Node> content)
        {
            Label = label; nodes = content.ToList();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="label"></param>
        /// <param name="content"></param>
        public Node(string label, params Node[] content)
            : this(label, content as IEnumerable<Node>)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="label"></param>
        /// <param name="content"></param>
        public Node(string label, string content)
        {
            Label = label; Begin = 0; End = content.Length; Input = content;
        }

        /// <summary>
        /// Returns length of the associated text
        /// </summary>
        public int Length
        {
            get
            {
                return End > Begin ? End - Begin : 0;
            }
        }

        /// <summary>
        /// Returns the associated text
        /// </summary>
        public string Text
        {
            get
            {
                return Input.Substring(Begin, Length);
            }
        }

        /// <summary>
        /// Returns the number of child nodes
        /// </summary>
        public int Count
        {
            get
            {
                return nodes.Count;
            }
        }

        /// <summary>
        /// Indicates whether there are any child nodes or not
        /// </summary>
        public bool isLeaf
        {
            get
            {
                return nodes.Count == 0;
            }
        }

        /// <summary>
        /// Returns all the child nodes with the label given
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public IEnumerable<Node> getNodes(string label)
        {
            //foreach (var n in nodes) {
                return nodes.Where(n => n.Label == label);
            //}
        }

        /// <summary>
        /// Returns the first child node with the given label
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public Node getNode(string label)
        {
            return getNodes(label).First();
        }

        /// <summary>
        /// Returns the first child node with given label 
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public Node this[string label]
        {
            get
            {
                return getNode(label);
            }
        }

        /// <summary>
        /// Returns the n'th child node with given label
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Node this[int n]
        {
            get
            {
                return nodes[n];
            }
        }

        /// <summary>
        /// Returns a string representation
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} : {1}", Label, Text);
        }
    }
}
