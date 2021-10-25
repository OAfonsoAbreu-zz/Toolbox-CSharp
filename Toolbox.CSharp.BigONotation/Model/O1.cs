using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox.CSharp.BigONotation.Util;

namespace Toolbox.CSharp.BigONotation.Model
{
    public class O1 : IBigO
    {
        /// <summary>
        /// O(1) is a representation of constant execution. 
        /// "1" represents a constant. 
        /// Algorithms will run only once, regardless of inputs.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Execute(int value)
        {
            using(new Watchdog())
            {
                Console.WriteLine($"O(1): \n {value}"); //O(1)

                return true;
            }
            
        }
    }
}
