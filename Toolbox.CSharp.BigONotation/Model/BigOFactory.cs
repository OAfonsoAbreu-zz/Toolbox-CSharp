using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.CSharp.BigONotation.Model
{
    public class BigOFactory
    {
        public IBigO Create(string type)
        {
            switch (type.ToUpper())
            {
                case "O1":
                    return new O1();
                case "ON":
                    return new ON();
                case "ON2":
                    return new ON2();
                case "OPT":
                    return new ON2Optimized();
                default:
                    return null;
            }
        }
    }
}
