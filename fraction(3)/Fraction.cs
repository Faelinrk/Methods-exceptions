using System;

namespace fraction_3_
{
    class Fraction
    {
        public double a, b;
        public Fraction(double x1,double x2)
        {
            a = x1;
            b = x2;
        }
        public void Print()
        {
            string temp = String.Empty;

            if (b == 1) temp = $"{a}";
            else temp = $"{a}/{b}";
            Console.WriteLine(temp);
        }

        public static Fraction Sum(Fraction z1, Fraction z2) //Сложение дробей
        {
            checkB(z1, z2);
            Fraction res = new Fraction(z1.a * z2.b + z2.a * z1.b, z1.b * z2.b);
            return res;
        }



        public static Fraction Sub(Fraction z1, Fraction z2) //Вычитание дробей
        {
            checkB(z1, z2);

            Fraction res = new Fraction(z1.a * z2.b - z2.a * z1.b, z1.b * z2.b);
            return res;
        }

        public static Fraction Mul(Fraction z1, Fraction z2) //Умножение дробей
        {

            checkB(z1, z2);

            Fraction res = new Fraction(z1.a *  z2.a, z1.b * z2.b);
            return res;
        }

        public static Fraction Div(Fraction z1, Fraction z2) //Умножение дробей
        {

            checkB(z1, z2);

            Fraction res = new Fraction(z1.a / z2.a, z1.b / z2.b);
            return res;
        }

        public static void simpleFr(Fraction z)
        {
            Program.GreenText((z.a / z.b).ToString("F2"));
        }

        static void checkB(Fraction z1, Fraction z2)
        {
            if (z1.b == 0 || z2.b == 0)
            {
                throw new ArgumentException("Знаменатель не должен равняться нулю");
            }
        }



    }
}