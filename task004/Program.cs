using System;

namespace task004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string sa = Console.ReadLine();
            int a = int.Parse(sa);
            Console.Write("Введите степень: ");
            string sb = Console.ReadLine();
            int b = int.Parse(sb);
            int sum = a;
            for(int i = 1; i < b; i++){
                Console.WriteLine(sum = sum * a);
            }
            Console.WriteLine($"Сумма число {a} в степени {b} = {sum}");
        }
    }
}
