//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



namespace Lesson8.HomeWork56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = FillMultiArrayInteger(4, 4, 1, 10);
            PrintMultiArrayInteger(myArray);
            
            // Цикл
            DateTime dt = DateTime.Now;
            int minimumSumm = 0;
            int mimimumRow = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                int curentSumm = 0;
                for (int j = 0; j < myArray.GetLength(1); j++)
                    curentSumm += myArray[i, j];
                if (minimumSumm == 0 || minimumSumm > curentSumm)
                {
                    minimumSumm = curentSumm;
                    mimimumRow = i;
                }    
            }

            Console.WriteLine($"Наименьшая сумма элементов ({minimumSumm}) в строке {mimimumRow + 1} (Цикл: затрачено {(DateTime.Now - dt).TotalMilliseconds} мс)");
            // End:Цикл

            // Рекурсия
            dt = DateTime.Now;
            Console.WriteLine($"{MinimumSummRecurse(myArray,0,0,0)} (Рекурсия: затрачено {(DateTime.Now - dt).TotalMilliseconds} мс)");


            string MinimumSummRecurse(int[,] arr, int minimum, int row, int numrow)
            {
                int summ = 0;
                if (row >= arr.GetLength(0)) 
                    return $"Наименьшая сумма элементов ({minimum}) в строке {numrow+1}";
                for (int i = 0; i < arr.GetLength(1); i++)
                    summ += arr[row,i] ;
                if (minimum == 0 || minimum > summ)
                {
                    numrow = row;
                    minimum = summ;
                }

                return $"{MinimumSummRecurse(arr, minimum, row+1, numrow)}";
            }
            // End:Рекурсия
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