using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    class Binary
    {
        private int _value;

        public Binary(int value)
        {
            this._value = value;
        }

        public static implicit operator Binary(string binary)
        {
            return new Binary(Convert.ToInt32(binary,2));
        }

        public static explicit operator int(Binary binary)
        {
            return binary._value;
        }

        public static Binary operator +(Binary a, Binary b)
        {
            return new Binary(a._value + b._value);
        }
        public static Binary operator -(Binary a, Binary b)
        {
            return new Binary(a._value - b._value);
        }
        public static Binary operator *(Binary a, Binary b)
        {
            return new Binary(a._value * b._value);
        }
        public static Binary operator /(Binary a, Binary b)
        {
            return new Binary(a._value / b._value);
        }

    }
    class BinaryCalculator : ICalculator<Binary>
    {

        public Binary Add(Binary a, Binary b)
        {
            throw new NotImplementedException();
        }

        public Binary Subtract(Binary a, Binary b)
        {
            throw new NotImplementedException();
        }

        public Binary Multiply(Binary a, Binary b)
        {
            throw new NotImplementedException();
        }

        public Binary Divide(Binary a, Binary b)
        {
            throw new NotImplementedException();
        }
    }
}
