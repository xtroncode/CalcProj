using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class IntegerCalculator : ICalculator<int>
    {
       public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a*b;
        }

        public int Divide(int a, int b)
        {
            return a/b;
        }


    }
}
