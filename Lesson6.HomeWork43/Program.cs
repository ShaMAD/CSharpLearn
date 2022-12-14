//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0, 5)

using System;

namespace Lesson6.HomeWork43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] coordinatesList = GetUserInputCoordinatesArray();

            Console.Write("[");
            foreach (var item in coordinatesList)
                Console.Write(" " + item);
            Console.WriteLine(" ]");


            // x = (b2-b1)/(k1-k2)
            double x = (coordinatesList[3] - coordinatesList[2])
                  / (coordinatesList[0] - coordinatesList[1]);

            //y = k1 * x + b1
            double y = coordinatesList[0] * x + coordinatesList[2];

            Console.WriteLine("x: " + x + ", y: " + y);
            
        }
        // <summary>
        /// Ввод 4 координаты в массив
        /// </summary>
        /// <returns>Массив 4 координат</returns>
        private static double[] GetUserInputCoordinatesArray()
        {
            double parsedNubmer = 0;
            string userInput = string.Empty;

            string coordinateNames = "kb";
            double [] inputArray = new double[4];

            for (int i = 0, j = 0; i < 2; i++)
            {
                for (int k = 1; k < 3; k++)
                {
                    Console.WriteLine("Введите значение координаты " + coordinateNames[i] + k + ": ");
                    userInput = Console.ReadLine()!.Replace('.', ',').Trim();

                    try
                    {
                        parsedNubmer = double.Parse(userInput);
                        inputArray[j] = parsedNubmer;
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неверный ввод!");
                        Environment.Exit(-100);
                    }
                }
            }
            
            return inputArray;
        }
    }
}
