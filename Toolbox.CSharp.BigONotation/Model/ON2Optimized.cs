using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox.CSharp.BigONotation.Util;

namespace Toolbox.CSharp.BigONotation.Model
{
    public class ON2Optimized : IBigO
    {
        /// <summary>
        /// In this example, we transform a O(n²) algorithm in O(n) one.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Execute(int value)
        {
            using (new Watchdog())
            {
                Console.WriteLine("O(n²) To O(n):");

                string temporary = string.Empty;

                for (int j = 0; j < value; j++)
                { //O(n)
                    temporary += string.Concat(value.ToString(), " ");
                }

                for (int i = 0; i < value; i++)
                { //O(n)
                    Console.Write("");
                    //Console.WriteLine(temporary);
                }

                return true;
            }

        }
    }
}
