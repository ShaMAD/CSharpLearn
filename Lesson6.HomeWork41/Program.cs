//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 4

using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson6.HomeWork41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = GetUserInputIntegerList();

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
        private static List<int> GetUserInputIntegerList()
        {
            int parsedNubmer = 0;
            string userInput = string.Empty;
            bool correctImput = false;

            List<int> list = new List<int>();
            
            Console.WriteLine("Введите любые числа, каждое с новой строки:");

            do
            {
                userInput = Console.ReadLine()!.Replace('.', ',').Trim();
                correctImput = int.TryParse(userInput, out parsedNubmer);
                if (correctImput) 
                    list.Add(parsedNubmer);

            } while (correctImput);
            return list;
        }
    }
}