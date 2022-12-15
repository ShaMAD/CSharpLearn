//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] array = FillMultiArrayInteger(3, 4, 1, 10);
//            PrintMultiArrayInteger(array);

//            for (int s = 0; s < array.GetLength(0); s++)
//            {
//                for (int i = 0; i < array.GetLength(1); i++)
//                {
//                    int k = array[s, i];
//                    int j = i - 1;

//                    while (j >= 0 && array[s, j] < k)
//                    {
//                        array[s, j + 1] = array[s, j];
//                        array[s, j] = k;
//                        j--;
//                    } 
//                }
//            }
//            Console.WriteLine();
//            PrintMultiArrayInteger(array);
//        }


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] array = FillMultiArrayInteger(4, 4, 1, 10);
//            PrintMultiArrayInteger(array);

//            int sum = 9990;

//            for (int i = 0; i < array.GetLength(0); i++)
//            {
//                int sum2 = 0;
//                for (int j = 0; j < array.GetLength(1); j++)
//                {
//                    sum2 += array[j, i];

//                }
//                Console.WriteLine(sum2);
//                if (sum > sum2) 
//                    sum = sum2; 
//            }
//            Console.WriteLine(sum);
//        }



//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] arrayA = FillMultiArrayInteger(2, 2, 1, 3);
//            int[,] arrayB = FillMultiArrayInteger(2, 2, 1, 3);
//            int[,] arrayC = FillMultiArrayInteger(2, 2, 0, 0);

//            PrintMultiArrayInteger(arrayA);
//            Console.WriteLine();
//            PrintMultiArrayInteger(arrayB);
//            Console.WriteLine();
//            PrintMultiArrayInteger(arrayC);
//            Console.WriteLine();
//            // c_{ ij}=\sum _{ r = 1} ^{ m} a_{ ir} b_{ rj}\;\;\;\left(i = 1, 2,\ldots l;\; j = 1,2,\ldots n\right).}


//            for (int i = 0; i < arrayC.GetLength(0); i++)
//            {
//                for (int j = 0; j < arrayC.GetLength(1); j++)
//                {
//                    int sum = 0;
//                    for (int k = 0; k < arrayA.GetLength(1); k++)
//                    {
//                        sum += arrayA[i, k] * arrayB[k, j];
//                    }
//                    arrayC[i,j] = sum;
//                }
//            }
//            Console.WriteLine();
//            PrintMultiArrayInteger(arrayC);
//        }


//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,,] a = new int[2, 2, 2];
//            string nums = "1234567890qwertyuiopasdfghjklzxcvbnm";

//            for (int i = 0,l=new Random().Next(20) ; i < a.GetLength(0); i++)
//            {
//                for (int j = 0; j< a.GetLength(1); j++)
//                {
//                    for (int k = 0; k < a.GetLength(2); k++)
//                    {

//                        //a[i, j, k] = nums[l];
//                        a[i, j, k] = new Random().Next(1,100);
//                        l++;
//                        Console.WriteLine(a[i, j, k]);
//                    }
//                }
//            }


//        }


//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] array = FillMultiArrayInteger(4, 4, 0, 0);
//            int a=0,j=0,a1=0,b1=0;

//            for (int i = 0; i < array.Length; i++)
//            {
//                array
//            }

//        }


//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 10;
//            Console.Write($"{PrintNums(n,1)}");

//            string PrintNums(int left,int right)
//            {
//            if (left <= right) 
//                return left.ToString();
//            return $"{left} {PrintNums(left - 1, right)}";

//            }

//        }

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m=3,n = 2;
            int i = 0;
            Console.WriteLine($"{Accerman(m,n)} {i}");
            int Accerman(int m, int n)
            {
                i++;
                if (m == 0)
                    return n + 1;
                else if (n == 0)
                    return Accerman(m - 1, 1);
                else
                    return Accerman(m - 1, Accerman(m, n - 1));

            }



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