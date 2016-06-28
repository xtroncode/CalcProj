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
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot perform division by zero.");
                return 0;
            }
            return a / b;
        }

        public int eval(string a, string op, string b)
        {
            switch (op)
            {
                case "+":
                    return Add(Convert.ToInt32(a), Convert.ToInt32(b));
                case "-":
                    return Subtract(Convert.ToInt32(a), Convert.ToInt32(b));
                case "*":
                    return Multiply(Convert.ToInt32(a), Convert.ToInt32(b));
                case "/":
                    return Divide(Convert.ToInt32(a), Convert.ToInt32(b));
                default:
                    return 0;
            }
        }
    }
}
