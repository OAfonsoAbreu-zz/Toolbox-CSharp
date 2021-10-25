using System;
using Toolbox.CSharp.BigONotation.Model;

namespace Toolbox.CSharp.BigONotation
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Big O notation is a form to measure the complexity and time of execution
             * from applications. Big O also help us improve our algorithms using some 
             * techniques
             * In Big O notation we keep the most significant term. Example, if we have
             * a part of code that execute on O(1), another part on O(n) and other on
             * O(n²), the Big O of this program is O(n²)
             */
            BigOFactory factory = new BigOFactory();

            int value = 1000;

            //Some examples to Big O notation
            IBigO bigO;

            //O(1) - Constant
            bigO = factory.Create("O1");
            bigO.Execute(value);

            //O(n) - Linear
            bigO = factory.Create("ON");
            bigO.Execute(value);

            //O(n²) - Exponential Function
            bigO = factory.Create("ON2");
            bigO.Execute(value);

            //O(n²) to O(n) - Optimization
            bigO = factory.Create("OPT");
            bigO.Execute(value);
        }
    }
}
