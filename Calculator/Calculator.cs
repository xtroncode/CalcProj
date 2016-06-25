using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculatorLib;

namespace Calculator
{
    class Calculator
    {
        public static void Main(string[] args)
        {   
            ICalculator<int> icalc = new IntegerCalculator(); 
            Console.WriteLine(icalc.Add(1,2));
            Console.Read();
        }
    }
}
