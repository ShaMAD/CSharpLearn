//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

using System;

namespace Lesson5.HomeWork36
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] intRandomArray = InitiateAndFillArray(5, -99, 100);

            int oddPositionSumm = OddPositionSumm(intRandomArray);

            Console.WriteLine($"Сумма нечётных позиций {intRandomArray.Length} элементов массива:");
            Console.Write("[");

            foreach (var item in intRandomArray)
                Console.Write(" " + item);

            Console.WriteLine(" ] -> " + oddPositionSumm);

            Console.Write("-> ");
            Console.WriteLine(oddPositionSumm);


            int OddPositionSumm(int[] array)
            {
                int oddPositionSumm = 0;

                for (int i = 0; i < intRandomArray.Length; i++)
                {
                    Console.Write(intRandomArray[i] + " ");
                    oddPositionSumm += (i % 2 == 1) ? intRandomArray[i] : 0;
                }
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