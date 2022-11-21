using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    struct LinearFunction
    {
        double k;
        double b;

        public LinearFunction (double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            double x = -b / k;
            return $"Корень уравнения вида kx+b=0: {x}"; 
        }

    }
}
