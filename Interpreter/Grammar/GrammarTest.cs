using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    public class GrammarTest
    {
        public static void Test(string s, Rule r)
        {
            try
            {
                var nodes = r.Parse(s);
                if (nodes.Count == 0 || nodes.Count != 1)
                {
                    Console.WriteLine("Parsing failed!");
                }
                else if (nodes[0].Text != s)
                    Console.WriteLine("Parsing partially succeeded");
                else
                    Console.WriteLine("Parsing succeeded!");
                Console.WriteLine(nodes[0].Text); 
            }
            catch (Exception e)
            {
                Console.WriteLine("Parsing failed with a message: " + e.Message);
            }
        }
    }
}
