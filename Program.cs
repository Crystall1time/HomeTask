using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите первое число: ");
            int firstNumber = GetNumber();

            Console.Write("Введите второе число: ");
            int secondNumber = GetNumber();

            Console.Write("Введите оператор: ");
            string arifmeticOperator = Console.ReadLine(); //!Уточнить//

            int result = 0;

            if (arifmeticOperator == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (arifmeticOperator == "-")
            {
                result = firstNumber - secondNumber;
            }
            else
            {
                Console.WriteLine("Ошибка");
                Console.ReadKey();
                return;//!Уточнить//
            }

            Console.Write("\nВведите свой ответ: ");
            int answer = GetNumber();

            if (answer == result)
            {
                Console.WriteLine("\nВаш ответ Правильный");
            }
            else
            {
                Console.WriteLine("\nВаш ответ Неверный");
                if (answer > result)
                {
                    Console.WriteLine("Ответ меньше указанного вами числа.");
                }
                else
                {
                    Console.WriteLine("Ответ больше указанного вами числа.");
                }
            }

            Console.ReadKey();
        }

        private static int GetNumber() //!Уточнить//
        {
            string numberString = Console.ReadLine();

            if (!int.TryParse(numberString,
            out int number))
            {
                Console.WriteLine("Не верно введено число!");
                return 0;
            }

            return number;
        }


    }

}
