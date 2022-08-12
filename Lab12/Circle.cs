using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    static class Circle
    {
        static public double GetCircumference(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetArea(double r)
        {
            return Math.PI * r * r;
        }
        static public double GetHypotenuse(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
