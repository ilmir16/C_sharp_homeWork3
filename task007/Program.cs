using System;

namespace task007
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[] {1,0,1,0,1,0,1,0};
            for(int i = 0; i < array.Length; i++){
                Console.WriteLine($"array[{i}] = {array[i]} ");
            }
        }
    }
}
