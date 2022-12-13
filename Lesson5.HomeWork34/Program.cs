//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2

using System;

namespace Lesson5.HomeWork34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int OddNumbersCount(int[] array)
            {
                int oddNumbersCount = 0;

                foreach (var item in array)
                    oddNumbersCount += (item % 2 == 0) ? 1 : 0;
                return oddNumbersCount;

            }

            int[] intRandomArray = InitiateAndFillArray(4, 100, 1000);

            Console.WriteLine($"Количество чётных чисел в массиве из {intRandomArray.Length} элементов:");
            Console.Write("[");

            foreach (var item in intRandomArray)
                Console.Write(" "+ item);

            //var oddNumbersCountLinq = intRandomArray
            //    .Where(e => e % 2 == 0)
            //    .Count();

            int oddNumbersCount = OddNumbersCount(intRandomArray);

            Console.WriteLine(" ] -> " + oddNumbersCount);
        }
        /// <summary>
        /// Задание размера массива и заполение случайными значениями
        /// </summary>
        /// <param name="length">Размер массива</param>
        /// <param name="minvalue">Минимальное число</param>
        /// <param name="maxvalue">Максимальное число</param>
        /// <returns>Заполненный массив</returns>
        private static int[] InitiateAndFillArray(int length, int minvalue, int maxvalue)
        {
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
                array[i] = new Random().Next(minvalue, maxvalue);
            return array;
        }
    }
}