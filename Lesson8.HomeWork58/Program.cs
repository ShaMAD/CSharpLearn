//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

namespace Lession8.HomeWork58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayA = FillMultiArrayInteger(2, 3, 1, 4);
            int[,] arrayB = FillMultiArrayInteger(arrayA.GetLength(1), 2, 1, 4);

            int[,] arrayMultiplication = FillMultiArrayInteger(arrayA.GetLength(0), arrayB.GetLength(1), 0, 0);

            PrintMultiArrayInteger(arrayA);
            Console.WriteLine();
            PrintMultiArrayInteger(arrayB);

            for (int i = 0; i < arrayMultiplication.GetLength(0); i++)// столбец
                for (int j = 0; j < arrayMultiplication.GetLength(1); j++) //строка
                {
                    int sum = 0;
                    for (int k = 0; k < arrayA.GetLength(1) && i < arrayA.GetLength(0); k++) //строка
                        sum += arrayA[i, k] * arrayB[k, j];
                    arrayMultiplication[i, j] = sum;
                }
            Console.WriteLine();
            PrintMultiArrayInteger(arrayMultiplication);
        }

        /// <summary>
        /// Печать двумерного массива
        /// </summary>
        /// <param name="array">Консольный вывод</param>
        public static void PrintMultiArrayInteger(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write("{0,-5}", array[i, j]);
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
        public static int[,] FillMultiArrayInteger(int heigth, int length, int minvalue, int maxvalue)
        {
            int[,] array = new int[heigth, length];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = new Random().Next(minvalue, maxvalue);
            return array;
        }
    }
}