using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox.CSharp.BigONotation.Util;

namespace Toolbox.CSharp.BigONotation.Model
{
    public class ON2 : IBigO
    {
        /// <summary>
        /// O(n²) represents a exponential function.
        /// "n²" means that there are more repeat structure on cascade.
        /// This algorithm has two repeat structure on cascade.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Execute(int value)
        {
            using (new Watchdog())
            {
                Console.WriteLine("O(n²):");

                for (int i = 0; i < value; i++)
                { //O(n)
                    for (int j = 0; j < value; j++)
                    { //O(n)
                        Console.Write("");
                        //Console.Write(string.Concat(value.ToString(), " ")); // O(n) + O(n) = O(n²)
                    }

                    //Console.WriteLine();
                }

                return true;
            }
            
        }
    }
}
