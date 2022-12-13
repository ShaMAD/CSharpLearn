//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

using System.Collections.Generic;

namespace Lesson6.HomeWork43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] coordinatesList = GetUserInputCoordinatesList();
            


        }
        private static double[] GetUserInputCoordinatesList()
        {
            double parsedNubmer = 0;
            string userInput = string.Empty;

            string coordinateNames = "kb";
            double array = new Array[4];

            for (int j = 0; j < 2; j++)
            {
                for (int i = 1; i < 3; i++)
                {
                    Console.WriteLine("Введите значение координаты " + coordinateNames[j] + i + ": ");
                    userInput = Console.ReadLine()!.Replace('.', ',').Trim();

                    try
                    {
                        parsedNubmer = double.Parse(userInput);
                        array[i+j] = parsedNubmer;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неверный ввод!");
                        Environment.Exit(-100);
                    }
                }
            }
            
            return array;
        }
    }
}
