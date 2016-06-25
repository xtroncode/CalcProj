using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    class StringCalculator : ICalculator<string>
    {
        public string Add(string a, string b)
        {
            return a + b;
        }

        public string Subtract(string a, string b)
        {   //TODO
            return a;
        }

        public string Multiply(string a, string b)
        {
            //TODO
            return a;
        }

        public string Divide(string a, string b)
        {
            //TODO
            return a;
        }
    }
}
