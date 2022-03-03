using System;

namespace VisualProgLab2
{
    internal class RomanNumber : ICloneable, IComparable
    {
        private ushort number = 0;

        public RomanNumber(ushort n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException("Ошибка использования значения 0");
            }
            number = n;
        }
        public override string ToString()
        {   
            ushort num = number;
            string stringRoman = "";
            ushort[] massMath = new ushort[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] massLang = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };

            for (int index = 12; index >= 0; --index)
            {
                if (num / massMath[index] != 0)
                {
                    for (int j = 0; j < num / massMath[index]; ++j)
                    {
                        stringRoman += massLang[index];
                    }
                    num %= massMath[index];
                }
            }
            return stringRoman;
        }
        public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null)
                return new RomanNumber((ushort)(n1.number + n2.number));
            else
                throw new RomanNumberException("Ошибка сложения");
        }
        public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null && n1.number > n2.number)
                return new RomanNumber((ushort)(n1.number - n2.number));
            else
                throw new RomanNumberException("Ошибка вычитания");
        }
        public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null && n1.number * n2.number <= 3999)
                return new RomanNumber((ushort)(n1.number * n2.number));
            else
                throw new RomanNumberException("Ошибка умножения");
        }
        public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null && n2.number != 0 && n1.number % n2.number == 0)
                return new RomanNumber((ushort)(n1.number / n2.number));
            else
                throw new RomanNumberException("Ошибка деления");
        }
        public object Clone()
        {
            return new RomanNumber(number);
        }
        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber rNumber)
                return number.CompareTo(rNumber.number);
            else
                throw new RomanNumberException("Ошибка сравнения");
        }
    }
}
