using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._52
{
    abstract class Shape
    {
        protected string FormatNumber(double x)
        {
            Math.Round(x, 2);
            string number = Convert.ToString(x);
            return number;
        }
    }
}
