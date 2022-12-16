//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)


namespace Lesson8.HomeWork60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[2, 2, 2];

            int[] numsArray = new int[myArray.Length*10];
            for (int i = 0; i < numsArray.Length; i++)
                numsArray[i] = i+1;

            for (int i = 0; i < myArray.GetLength(0); i++)
                for (int j = 0; j < myArray.GetLength(1); j++)
                    for (int k = 0; k < myArray.GetLength(2); k++)
                        while (myArray[i, j, k] == 0)
                        {
                            int rnd = new Random().Next(0, numsArray.Length);
                            if (numsArray[rnd] != 0)
                            {
                                myArray[i, j, k] = numsArray[rnd];
                                numsArray[rnd] = 0;
                            }
                        }

            for (int i = 0; i < myArray.GetLength(0); i++)
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                        Console.Write("{0,2}({1}, {2}, {3}) ", myArray[j, k, i],j,k,i);
                    Console.WriteLine();
                }
        }
    }
}