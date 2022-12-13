//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

using System;

namespace Lesson5.HomeWork38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intRandomArray = InitiateAndFillArray(4, 1, 100);

            int raznostMinMax = RaznostMinMax(intRandomArray);

            Console.WriteLine($"Разница между максимальным и минимальным элементом массива:");
            Console.Write("[");            

            foreach (var item in intRandomArray)
                Console.Write(" "+ item);

            Console.WriteLine(" ] -> " + raznostMinMax);


            int RaznostMinMax(int[] array)
            {
                int minvalue = array[0], maxvalue = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    maxvalue = (maxvalue > array[i]) ? maxvalue : array[i];
                    minvalue = (minvalue < array[i]) ? minvalue : array[i];
                }
                return maxvalue - minvalue;
            }

            int[] intRandomArray = InitiateAndFillArray(4, 1, 100);

            Console.WriteLine("Разница между максимальным и минимальным элементом массива:");
            Console.Write("[");            

            foreach (var item in intRandomArray)
                Console.Write(" "+ item);

            int raznostMinMax = RaznostMinMax(intRandomArray);

            Console.WriteLine(" ] -> " + raznostMinMax);
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