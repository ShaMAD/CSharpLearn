//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30


namespace Lesson9.HomeWork66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = UserInputInteger("Введите число M: ");
            int n = UserInputInteger("Введите число N: ");

            Console.Write($"Сумма натуральных элементов между '{m}' и '{n}' равна "+SummElem(m, n));

            int SummElem(int m, int n)
            {
                if (m >= n)
                    return m;
                return m + SummElem(m+1,n);
            }
        }


        /// <summary>
        /// Ввод числа с клавиатуры
        /// </summary>
        /// <returns>Число integer</returns>
        public static int UserInputInteger(string text)
        {
            int inputInteger = 0;
            try
            {
                Console.Write(text);
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