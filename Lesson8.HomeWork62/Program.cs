//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

namespace Lesson8.HomeWork62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = FillMultiArrayInteger(7, 5, 0, 0);

            int coordX = 0, coordY = 0, napravlenie = 0;
            //Console.WriteLine(array.GetLength(0)+"-"+ array.GetLength(1));
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[coordY, coordX] == 0)
                    myArray[coordY, coordX] = i + 1;

                if ((coordX + 1) < myArray.GetLength(1) && napravlenie == 0 && (myArray[coordY, coordX + 1] == 0))
                    {
                        coordX++;
                        continue;
                    }  
                else
                    napravlenie = napravlenie == 0 ? 1 : napravlenie;

                if ((coordY + 1) < myArray.GetLength(0) && napravlenie == 1 && (myArray[coordY + 1, coordX] == 0))
                    {
                        coordY++;
                        continue;
                    }
                else
                    napravlenie = napravlenie == 1 ? 2 : napravlenie;

                if ((coordX - 1) >= 0 && napravlenie == 2 && (myArray[coordY, coordX - 1] == 0))
                    {
                        coordX--;
                        continue;
                    }
                else
                    napravlenie = napravlenie == 2 ? 3 : napravlenie;
                if ((coordY - 1) >= 0 && napravlenie == 3 && (myArray[coordY - 1, coordX] == 0))
                    {
                        coordY--;
                        continue;
                    }
                else
                {
                    coordX++;
                    napravlenie = napravlenie == 3 ? 0 : napravlenie;
                }
            }
            PrintMultiArrayInteger(myArray);
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
                    Console.Write("{0,-5:D2}", array[i, j]);
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