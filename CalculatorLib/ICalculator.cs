using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public interface ICalculator<T>
    {
          T Add (T a, T b);
          T Subtract(T a, T b);
          T Multiply(T a, T b);
          T Divide(T a, T b);
          T eval(string a,string op, string b);  
    }
}
