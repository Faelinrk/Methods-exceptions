using System;

namespace ConsoleApp19
{


   
    class Complex
    {
        public double a, b;

       

        public Complex(double v1, double v2)  
        {
            a = v1;
            b = v2;
        }

        public void Print()
        {
            string temp = String.Empty;

            if (a == 0) temp = $"";
            else temp = $"{a}";

            if (b == 0) temp += $"";
            else if (b > 0) temp += $" + {b}i";
            else temp += $" - {-b}i";
            if (a == 0 && b == 0) temp = "0";
            Console.WriteLine(temp);
        }

        public static Complex Sum(Complex z1, Complex z2) //Сложение комплексных чисел
        {
             

            Complex res = new Complex(z1.a + z2.a, z1.b + z2.b);

            return res;
        }

        public static Complex Sub(Complex z1, Complex z2) //Вычитание комплексных чисел
        {


            Complex res = new Complex(z1.a - z2.a, z1.b - z2.b);

            return res;
        }

        public static Complex Mul(Complex z1, Complex z2) //Произведение комплексных чисел
        {

              Complex res = new Complex((z1.a*z2.a) - (z1.b * z2.b),((z1.a* z2.b) + (z1.b* z2.a)));

            return res;
        }



    }
}
