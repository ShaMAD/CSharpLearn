//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17->такого числа в массиве нет

namespace Lesson7.HomeWork50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] doubleArray = MultiArray.InitiateAndFillMultiArrayDouble(5, 5, 0, 10);
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
        /// Иницилизация и заполнение двумерного массива натуральными числами
        /// </summary>
        /// <param name="length">Количество столбцов массива</param>
        /// <param name="heigth">Количество строк массива</param>
        /// <param name="minvalue">Минимальное значение для заполнения массива</param>
        /// <param name="maxvalue">Максимальное значение для заполнения массива</param>
        /// <returns>Двумерный массив</returns>
        public static int[,] InitiateAndFillMultiArrayInteger(int length, int heigth, int minvalue, int maxvalue)
        {
            int[,] array = new int[length, heigth];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] =  new Random().Next(minvalue, maxvalue);
                }


            return array;
        }
    }
}