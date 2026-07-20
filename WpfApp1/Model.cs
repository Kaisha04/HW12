using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Model
    {

        public double Add(double first, double second) => first + second;
        public double Substract(double first, double second) => first - second;
        public double Multiply(double first, double second) => first * second;
        public double Divide(double first, double second)
        {
            if (second == 0) return 0;
            return first / second;
        }
    }
}
