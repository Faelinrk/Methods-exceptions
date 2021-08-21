using System;

namespace fraction_3_
{

    //    3. * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    //** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    // ArgumentException("Знаменатель не может быть равен 0");
    //    Добавить упрощение дробей.
    class Program
    {
        static void Main(string[] args)
        {
            Fraction z1 = new Fraction(1, 4);
            Fraction z2 = new Fraction(1, 14);
            GreenText("Заданные дроби:");

            z1.Print(); z2.Print();
            Console.WriteLine("");

            Fraction z = Fraction.Sum(z1, z2);

            GreenText("Сложение дробей:");
            z.Print();
            Fraction.simpleFr(z);
            Console.WriteLine("");

            z = Fraction.Sub(z1, z2);

            GreenText("Вычитание дробей:");
            z.Print();
            Fraction.simpleFr(z);
            Console.WriteLine("");

            z = Fraction.Mul(z1, z2);
            GreenText("Умножение дробей:");
            z.Print();
            Fraction.simpleFr(z);
            Console.WriteLine("");

            z = Fraction.Div(z1, z2);
            GreenText("Деление дробей:");
            z.Print();
            Fraction.simpleFr(z);

            Console.ReadLine();

        }

        public static void GreenText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
