using System;

namespace ConsoleApp19
{



    internal struct QuadraticEquation
    {
        private double a;
        private double b;
        private double c;

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Print()
        {
            string s = $"{a}x^2 + {b}x + {c} = 0";
            Console.WriteLine(s);
        }

        public void Solve()
        {
            double D = b * b - 4 * a * c;
             if(D > 0)
            {

                double x1 = (-b + Math.Sqrt(D))/(2*a);
                double x2 = (-b - Math.Sqrt(D))/(2*a);
                Console.WriteLine($"x1 = {x1} x2 = {x2}");
            }
             else if (D == 0)
            {
                double x1 = (-b ) / (2 * a);

                Console.WriteLine($"x = {x1}");

            }
            else
            {

                double x1 = (-b + Math.Sqrt(-D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(-D)) / (2 * a);

               var r1 = new Complex(0, x1);
                var r2 = new Complex(0, x2);

                r1.Print();
                r2.Print();
                
            }

        }

    }
}