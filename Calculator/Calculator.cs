using System;

using CalculatorLib;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Calculator
    {
        static string consoleMessage = @"We support operations on integer,binary and string.
                      for integer: e.g. 1+2
                      for binary: e.g. b100+b100
                      for string: e.g. a+b
Press Ctrl+C to exit.";
        public static void Main(string[] args)
        {
            Console.WriteLine(consoleMessage);
            while (true)
            {
                Console.Write('>');
                var input = Console.ReadLine();
                string output;
                EvaluateInput(input,out output);
                Console.WriteLine(output);
            }
            
        }

        private static void EvaluateInput(string input,out string output)
        {
            input = input.Trim();

            //
            // Use Regex to identify the input type and split into tokens.
            //

            var intOpRegex = @"^\d+\s*(\+|\-|\*|\/)\s*\d+$";
            var binOpRegex = @"^b[01]+\s*(\+|\-|\*|\/)\s*b[01]+$";
            var strOpRegex = @"^[A-Za-z0-9]+\s*(\+|\-|\*|\/)\s*[A-Za-z0-9]+$";
            string[] tokens = Regex.Split(input, @"(\+|\-|\*|\/)");
            
            if (Regex.IsMatch(input, intOpRegex))
            {
                ICalculator<int> intCalc = new IntegerCalculator();
                output = intCalc.eval(tokens[0], tokens[1], tokens[2].TrimStart()).ToString();
               
            }
            else if (Regex.IsMatch(input, binOpRegex))
            {
                ICalculator<Binary> binCalc = new BinaryCalculator();
                output = binCalc.eval(tokens[0].Substring(1, tokens[0].Length - 1).TrimEnd(), tokens[1], tokens[2].TrimStart().Substring(1)).ToString();
            }
            else if(Regex.IsMatch(input,strOpRegex))
            {
                ICalculator<string> strCalc = new StringCalculator();
                output = strCalc.eval(tokens[0].TrimEnd(), tokens[1], tokens[2].TrimStart());
            }
            else
            {
                output = "Operation cannot be performed.";
            }
        }
    }
}
