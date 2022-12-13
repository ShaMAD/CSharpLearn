//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Lesson6.HomeWork41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> listNumbers = GetUserInputIntegerList();

            var numGreatZero = listNumbers
                .Where(x => x > 0)
                .Count();

            Console.Write("[");
            listNumbers.ForEach(e => { Console.Write(" " + e); });
            Console.WriteLine(" ]"); 

            Console.WriteLine("Было введено '" + numGreatZero + "' чисел больше 0");
        }
        /// <summary>
        /// Получение коллекции введенных с клавиатуры чисел
        /// </summary>
        /// <returns>Коллекция чисел</returns>
        private static List<double> GetUserInputIntegerList()
        {
            double parsedNubmer = 0;
            string userInput = string.Empty;
            List<double> list = new List<double>();

            Console.WriteLine("Введите любые числа, каждое с новой строки:");

            while (true)
            {
                userInput = Console.ReadLine()!.Replace('.', ',').Trim();

                try
                {
                    parsedNubmer = double.Parse(userInput);
                    list.Add(parsedNubmer);
                }
                catch (Exception)
                {
                    break;
                } 
            }
            return list;
        }
    }
}