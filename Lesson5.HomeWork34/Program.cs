﻿//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2

using System;

namespace Lesson5.HomeWork34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intRandomArray = new int[4];

            for (int i = 0; i < intRandomArray.Length; i++)
            {
                Random random = new Random();
                intRandomArray[i] = random.Next(100, 1000);
            }

            int oddNumbersCount = 0;

            foreach (var item in intRandomArray)
            {
                Console.Write(item + " ");
                oddNumbersCount += (item % 2 == 0) ? 1 : 0;

            }

            //var oddNumbersCountLinq = intRandomArray
            //    .Where(e => e % 2 == 0)
            //    .Count();

            Console.Write("-> ");
            Console.WriteLine(oddNumbersCount);
        }
    }
}