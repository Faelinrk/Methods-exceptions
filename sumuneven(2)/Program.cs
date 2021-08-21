using System;

namespace sumuneven_2_
{
    //2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
    //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
    class Program
    {
        static void Main(string[] args)
        {
            sumUnEven();
            Console.ReadLine();
        }
        
        static void sumUnEven()
        {
            Console.WriteLine("Введите число. Для окончания вычисления введите 0.");
            string input = Console.ReadLine();
            int sum = 0;
            string sumstring = "Введённые нечетные числа:";
                Int32.TryParse(input, out int num);
                if (checkForGood(input) && (num % 2) != 0)
                {
                    sum += num;
                    sumstring += ($" {num}");
                }
            while (num != 0)
            {
                Console.WriteLine("Введите следующее число. Для окончания вычисления введите 0.");
                input = Console.ReadLine();
                Int32.TryParse(input, out num);
                if (checkForGood(input) &&  (num % 2) != 0)
                {
                    sum += num;
                    sumstring += ($" {num}");
                }
            }
            Console.WriteLine(sumstring);
            Console.WriteLine($"Сумма этих чисел: {sum}");
        }
        static bool checkForGood(string str)
        {
            Int32.TryParse(str, out int num);
            if (str != "0" && num == 0)
            { Console.WriteLine("Введено неверное значение. Операция прервана."); return false; }
            else 
            {return true; }
        }


    }
}
