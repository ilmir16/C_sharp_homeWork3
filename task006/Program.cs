using System;

namespace task006
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Введите число: ");
            string sa = Console.ReadLine();
            int a = int.Parse(sa);
            Console.Write("Введите число: ");
            string sb = Console.ReadLine();
            int b = int.Parse(sb);
            if (a < b)
            {
                for(int i = a; i <= b; i++){
                if (i % 2 == 0){
                    Console.WriteLine($"{i} в кубе = {(i * i * i)}");
                }
            }
            }
            else
            {
                for(int i = b; i <= a; i++){
                if (i % 2 == 0){
                    Console.WriteLine($"{i} в кубе = {(i * i * i)}");
                }
            }
            }
            
        }
    }
}
