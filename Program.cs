using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{

    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Заданные комплексные числа:");

            Complex z1 = new Complex(1, 4);

            z1.Print();

            Complex z2 = new Complex(2, 5);

            z2.Print();

            Console.WriteLine("Вычитание комплексных чисел:");

            Complex z = Complex.Sub(z1, z2);
            z.Print();

            Console.WriteLine("Сложение комплексных чисел:");

            z = Complex.Sum(z1, z2);
            z.Print();


            Console.WriteLine("Произведение комплексных чисел:");

            z = Complex.Mul(z1, z2);
            z.Print();

            Console.ReadLine();

        }





    }
}
