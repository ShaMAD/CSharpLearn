using Lesson7.HomeWork52.Array;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите число 1: ");
            int.TryParse(Console.ReadLine()!, out a);
            Console.WriteLine("Введите число 2: ");
            int.TryParse(Console.ReadLine()!, out b);

            Console.WriteLine($"{pow(a, b)}");

            int pow( int a, int b)
            {
                if (b == 0)
                    return 1;
                if (b == 1)
                    return a;
                return a* pow( a, b -1);
            }
            
        }
    }
}