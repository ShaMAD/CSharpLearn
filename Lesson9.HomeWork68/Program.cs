//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29


namespace Lesson9.HomeWork68
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int m = UserInputInteger("Введите число m: ");
                int n = UserInputInteger("Введите число n: ");

                DateTime dt = DateTime.Now;
                Console.WriteLine($"Аккерман от m={m}, n={n} равна " +
                    $"{Accerman(m, n)}, найдено за: " +
                    $"{Math.Round((DateTime.Now-dt).TotalMilliseconds,2) } мс");

                int Accerman(int m, int n)
                {
                    if (m == 0)
                        return n + 1;
                    else if (n == 0)
                        return Accerman(m - 1, 1);
                    else
                        return Accerman(m - 1, Accerman(m, n - 1));
                }



            }
        /// <summary>
        /// Ввод числа с клавиатуры
        /// </summary>
        /// <returns>Число integer</returns>
        public static int UserInputInteger(string text)
        {
            int inputInteger = 0;
            try
            {
                Console.Write(text);
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
    }
    }