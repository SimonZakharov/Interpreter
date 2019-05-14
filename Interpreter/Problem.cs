using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    public class Problem
    {
        public string Name { get; set; }
        public ushort Number { get; set; }

        /// <summary>
        /// Universal constructor of a problem
        /// </summary>
        /// <param name="number">Index number of the problem (must be positive!)</param>
        /// <param name="name">Name of the problem (must be unique!)</param>
        public Problem(ushort number, string name)
        {
            Name = name; Number = number;
        }


    }
}
