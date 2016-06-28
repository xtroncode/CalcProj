using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class StringCalculator : ICalculator<string>
    {
        public string Add(string a, string b)
        {
            return a + b;
        }

        public string Subtract(string a, string b)
        {
            int subStrIndex = a.LastIndexOf(b);
            if (a.Length == subStrIndex + b.Length)
            {
                return a.Substring(0, subStrIndex);
            } 
            
            return a;
        }

        public string Multiply(string a, string b)
        {
            StringBuilder aChars = new StringBuilder(a);
            StringBuilder answer = new StringBuilder();
            for (int i = 0; i < a.Length; i++)
            {
                answer.Append(aChars[i]+b);
            }
            return answer.ToString();
        }

        public string Divide(string a, string b)
        {
            return a.Replace(b, String.Empty);
        }
        public string eval(string a, string op, string b)
        {
            switch (op)
            {
                case "+":
                    return Add(a, b);
                case "-":
                    return Subtract(a, b);
                case "*":
                    return Multiply(a, b);
                case "/":
                    return Divide(a, b);
                default:
                    return String.Empty;
            }
        }
    }
}
