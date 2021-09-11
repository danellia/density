using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Props
    {
        double a;
        double b;
        double h;
        double m;
        double density;
        int precision = 6;

        public Props(double A, double B, double H, double M)
        {
            a = A;
            b = B;
            h = H;
            m = M;
        }

        public double findDensity()
        {
            density = Math.Round(m / (a * b * h), precision);
            return density;
        }
    }
}
