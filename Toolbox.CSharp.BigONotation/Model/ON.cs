using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox.CSharp.BigONotation.Util;

namespace Toolbox.CSharp.BigONotation.Model
{
    public class ON : IBigO
    {
        /// <summary>
        /// O(n) represents a linear execution.
        /// "n" represents the number of repeteation.
        /// This algorithm has a reapeat struture.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Execute(int value)
        {
            using (new Watchdog())
            {
                Console.WriteLine("O(n): ");

                for (int i = 0; i < value; i++)
                { //O(n)
                    Console.Write("");
                    //Console.WriteLine(value.ToString());
                }

                return true;
            }

        }
    }
}
