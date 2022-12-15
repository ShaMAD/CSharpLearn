//Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

namespace Lesson7.HomeWork52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiArray = FillMultiArrayInteger(
                length: 3,
                heigth: 4,
                minvalue: 1,
                maxvalue: 10);
            PrintMultiArrayInteger(multiArray);

            Console.WriteLine();

            PrintColumnSrednOrifm(multiArray);
        }


        /// <summary>
        /// Подсчет среднего арифметического по столбцам
        /// </summary>
        /// <param name="array">Массив чисел</param>
        public static void PrintColumnSrednOrifm(int[,] array)
        {
            Console.WriteLine("Среднее арифметическое каждого столбца: ");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                double sredOrifm = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                    sredOrifm += array[j, i];
                sredOrifm = Math.Round((double)sredOrifm / array.GetLength(0), 2);
                Console.Write("{0,-5:f2}", sredOrifm);
            }
        }
    }

    public class Array { 

    /// <summary>
    /// Печать двумерного массива
    /// </summary>
    /// <param name="array">Консольный вывод</param>
    public static void PrintMultiArrayInteger(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write("{0,-5}",array[i, j]);
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
        public static int[,] FillMultiArrayInteger(int length, int heigth, int minvalue, int maxvalue)
        {
            int[,] array = new int[length, heigth];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = new Random().Next(minvalue, maxvalue);
            return array;
        }
    }
}