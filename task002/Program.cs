using System;

namespace task002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string sa = Console.ReadLine();
            int a = int.Parse(sa);
            int i = 1;
            while(i <= a){
                Console.WriteLine($"Куб числа {i} = {i * i * i}");
                i++;
            }
        }
    }
}
