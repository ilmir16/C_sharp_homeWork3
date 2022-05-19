using System;

namespace task005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string sa = Console.ReadLine();
            int a = int.Parse(sa);
            int len = sa.Length;
            int [] array = new int[len];
            int sum = 0;
            for(int i = 0; i <= len - 1; i++){
                array[i] = a % 10;
                sum = sum + array[i];
                a = a / 10;
            }
            Console.WriteLine($"Сумма числа {sa} = {sum}");
        }
    }
}
