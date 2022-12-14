//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17->такого числа в массиве нет

namespace Lesson7.HomeWork50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] integerArray = FillMultiArrayInteger(
                length: 7,
                heigth: 5,
                minvalue: 10,
                maxvalue: 100);
            PrintMultiArrayInteger(integerArray);

            int inputInteger=UserInputInteger();
            FindInMultiArrayInteger(integerArray, inputInteger);
        }


        /// <summary>
        /// Поиск числа в двумерном массиве
        /// </summary>
        /// <param name="array">Массив для поиска</param>
        /// <param name="value">Число для поиска</param>
        public static void FindInMultiArrayInteger(int[,] array, int value)
        {
            bool isFound = false;

            for (int i = 0; i < array.GetLength(0) && !isFound; i++)
                for (int j = 0; j < array.GetLength(1) && !isFound; j++)
                    if (array[i,j] == value)
                    {
                        Console.WriteLine($"Введенное значение '{value}' найдено в ячейке [{i+1},{j+1}]");
                        isFound = true;
                    }
            if (isFound == false)
                Console.WriteLine("Введенное значение '" + value + "' не найдено в массиве");
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
                    Console.Write("{0,-3}", array[i, j]);
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Вврд числа с клавиатуры
        /// </summary>
        /// <returns>Число integer</returns>
        public static int UserInputInteger()
        {
            int inputInteger = 0;
            try
            {
                Console.Write("Введите значение для поиска: ");
                string userInput = Console.ReadLine()!;
                inputInteger = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка преобразования строки в число!");
                Environment.Exit(-100);
            }
            return inputInteger;
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
                    array[i, j] =  new Random().Next(minvalue, maxvalue);
            return array;
        }
    }
}