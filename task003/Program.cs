using System;

namespace task003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string sa = Console.ReadLine();
            int a = int.Parse(sa);
            int sum = 0;
            for(int i = 1; i <= a; i++){
                sum = i + sum;
            }
            Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
        }
    }
}
