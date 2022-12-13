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
            int[] intRandomArray = new int[4];

            for (int i = 0; i < intRandomArray.Length; i++)
            {
                Random random = new Random();
                intRandomArray[i] = random.Next(-99, 100);
            }

            int oddPositionSumm = 0;

            for (int i = 0; i < intRandomArray.Length; i++)
            {
                Console.Write(intRandomArray[i] + " ");
                oddPositionSumm += (i % 2 == 1) ? intRandomArray[i] : 0;
            }

            Console.Write("-> ");
            Console.WriteLine(oddPositionSumm);
        }
    }
}