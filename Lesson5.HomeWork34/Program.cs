//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2


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

            var oddNumbersCount = intRandomArray
                .Where(e => e % 2 == 0)
                .Count();

            foreach (var item in intRandomArray)
            {
                Console.Write(item + " ");
            }

            Console.Write("-> ");
            Console.WriteLine(oddNumbersCount);
        }
    }
}