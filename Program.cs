using System;

namespace HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N;
            N = int.Parse(Console.ReadLine());
            int[] arrey = new int[N];
            for(int i = 0; i < arrey.Length; i++){
                arrey[i]=new Random().Next(50);
                Console.Write($"{arrey[i]} ");
            }
            
        }
    }
}
