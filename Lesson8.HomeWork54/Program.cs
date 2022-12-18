//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


namespace Lesson8.HomeWork54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = FillMultiArrayInteger(5, 6, 1, 25);

            // Копия массива для вывода двух массивов после каждой сортировки чисел в строке
            //
            //int[,] originalArray = myArray.Clone() as int[,];

            PrintMultiArrayInteger(myArray);

            for (int i = 0; i < myArray.GetLength(0); i++)
                for (int j = 1; j < myArray.GetLength(1); j++)
                {
                    int temp = myArray[i, j];
                    for (int l = j - 1; l >= 0 && temp> myArray[i, l]; l--)
                    {
                        myArray[i, l + 1] = myArray[i, l];
                        myArray[i, l] = temp;
                    }
                    // Вывод двух массивов после каждой сортировки чисел в строке
                    //
                    /*Console.Clear();
                    PrintMultiArrayInteger(myArray);
                    Console.WriteLine();
                    PrintMultiArrayInteger(arraySorted);
                    Console.ReadKey();*/
                }
            Console.WriteLine();
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
