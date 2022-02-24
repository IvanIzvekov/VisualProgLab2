using System;

namespace VisualProgLab2
{
    class Program
    {
        static void Main()
        {
            RomanNumber z = new RomanNumber(28);
            RomanNumber x = new RomanNumber(74);
            RomanNumber l = new RomanNumber(8);
            RomanNumber o = new RomanNumber(1679);
            RomanNumber y = new RomanNumber(3001);
            Console.WriteLine(z.ToString());
            Console.WriteLine(x.ToString());
            Console.WriteLine(l.ToString());
            Console.WriteLine(o.ToString());
            Console.WriteLine(y.ToString());
            RomanNumber A = new RomanNumber(15);
            RomanNumber B = new RomanNumber(5);
            Console.WriteLine("A: " + A.ToString());
            Console.WriteLine("B: " + B.ToString());
            Console.WriteLine("Сумма A и B, ожидается: XX итог: " + RomanNumber.Add(A, B));
            Console.WriteLine("Вычитание A и B, ожидается: X итог: " + RomanNumber.Sub(A, B));
            Console.WriteLine("Умножение A и B, ожидается: LXXV итог: " + RomanNumber.Mul(A, B));
            Console.WriteLine("Деление A и B, ожидается: III итог: " + RomanNumber.Div(A, B));

            RomanNumber a = new RomanNumber(56);
            RomanNumber b = new RomanNumber(8);
            RomanNumber c = new RomanNumber(232);
            RomanNumber d = new RomanNumber(3452);

            Console.WriteLine("Sort: ");
            RomanNumber[] nums = { a, b, c, d };
            Array.Sort(nums);
            foreach (RomanNumber num in nums)
                Console.WriteLine("* " + num.ToString());

            Console.WriteLine("Clone: \na = " + a);
            var q = (RomanNumber)a.Clone();
            a = (RomanNumber)b.Clone();
            Console.WriteLine("q = " + q + "\na = " + a);
            Console.WriteLine("Compare: \nb & b\n" + b.CompareTo(b));
            Console.WriteLine("Compare: \nc & b\n" + c.CompareTo(b));
        }
    }
}
