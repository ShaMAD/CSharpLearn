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
            double[,] doubleArray = MultiArray.InitiateAndFillMultiArrayDouble(
                length: 5,
                heigth: 4,
                minvalue: 0,
                maxvalue: 10);

            MultiArray.PrintMultiArrayDouble(doubleArray);
        }


    }

    class MultiArray
    {
        /// <summary>
        /// Печать двумерного массива
        /// </summary>
        /// <param name="array">Консольный вывод</param>
        public static void PrintMultiArrayDouble(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
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
        /// <returns>Двумерный массиы</returns>
        public static double[,] InitiateAndFillMultiArrayDouble(int length, int heigth, int minvalue, int maxvalue)
        {
            double[,] array = new double[length, heigth];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minvalue, maxvalue), 2);
                }


            return array;
        }
    }
    class SingleArray
    {
        /// <summary>
        /// Задание размера массива и заполение случайными значениями
        /// </summary>
        /// <param name="length">Размер массива</param>
        /// <param name="minvalue">Минимальное число</param>
        /// <param name="maxvalue">Максимальное число</param>
        /// <returns>Заполненный массив</returns>
        public static int[] InitiateAndFillArrayInteger(int length, int minvalue, int maxvalue)
        {
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
                array[i] = new Random().Next(minvalue, maxvalue);
            return array;
        }

        /// <summary>
        /// Печать одномерного int массива
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArrayInteger(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

    }

}
        
