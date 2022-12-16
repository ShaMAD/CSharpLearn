//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

namespace Lesson9.HomeWork64
{
        internal class Program
    {
        static void Main(string[] args)
        {
            int n = UserInputInteger();


            Console.Write($"{PrintNums(n, 1)}");

            string PrintNums(int intdynamic, int intfixed)
            {
                if (intdynamic <= intfixed)
                    return intdynamic.ToString();
                return $"{intdynamic} {PrintNums(intdynamic - 1, intfixed)}";

            }

        }


        /// <summary>
        /// Вврд числа с клавиатуры
        /// </summary>
        /// <returns>Число integer</returns>
        public static int UserInputInteger()
        {
            int inputInteger = 0;
            try
            {
                Console.Write("Введите число: ");
                string userInput = Console.ReadLine()!;
                inputInteger = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка преобразования строки в число!");
                Environment.Exit(-100);
            }
            return inputInteger;
        }

    }
}