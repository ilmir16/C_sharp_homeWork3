using System;

namespace task001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string sa = Console.ReadLine();
            int a = int.Parse(sa);
            for(int i = 1; i <= a; i++)
            {
                Console.WriteLine($"Квадрат числа {i} = {i * i}");
            }
        }
    }
}
