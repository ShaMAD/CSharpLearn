//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

using System;

namespace Lesson7.HomeWork47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] doubleArray = FillMultiArrayDouble(
                length: 3,
                heigth: 4,
                minvalue: 0,
                maxvalue: 10);

            PrintMultiArrayDouble(doubleArray);
        }


        /// <summary>
        /// Печать двумерного массива
        /// </summary>
        /// <param name="array">Консольный вывод</param>
        public static void PrintMultiArrayDouble(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write("{0,-5:f2}", array[i, j]); 
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Иницилизация и заполнение двумерного массива вещественными числами
        /// </summary>
        /// <param name="length">Количество столбцов массива</param>
        /// <param name="heigth">Количество строк массива</param>
        /// <param name="minvalue">Минимальное значение для заполнения массива</param>
        /// <param name="maxvalue">Максимальное значение для заполнения массива</param>
        /// <returns>Двумерный массив</returns>
        public static double[,] FillMultiArrayDouble(int length, int heigth, int minvalue, int maxvalue)
        {
            double[,] array = new double[length, heigth];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minvalue, maxvalue), 2);
            return array;
        }
    }
}
        
