using System;
using System.Linq;

namespace HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_2
            Console.Write("N = ");
            int N;
            N = int.Parse(Console.ReadLine());
            int[] arrey = new int[N];
            for(int i = 0; i < arrey.Length; i++){
                arrey[i]=new Random().Next(50);
                Console.Write($"{arrey[i]} ");
            }
            Console.WriteLine($"\nMaxValue = {arrey.Max()}");
            Console.WriteLine($"MinValue = {arrey.Min()}");
            Console.WriteLine($"SumValue = {arrey.Sum()}");
            Console.WriteLine($"Avarage = {arrey.Average()}");
            for(int i = 0; i < arrey.Length; i++)
            {
                if(arrey[i] % 2 == 1)
                {
                    Console.Write($"{arrey[i]} ");
                }
            }
            //EndTask_2

            //Task_3
            int[] mas = new int[10];
            Console.WriteLine("\n\t\t\tArrey");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = new Random().Next(10, 20);
                Console.Write($"{mas[i]}  ");
            }
            Console.WriteLine();
            Array.Reverse(mas);
            Console.WriteLine("\t\tМассив в обратном порядке");
            for (int i = 0; i < mas.Length; i++)
            {
                 Console.Write($"{mas[i]}  ");
            }
            //EndTask_3

            //Task_4
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            int[] arrey = new int[N];
            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i] = new Random().Next(50);
                Console.Write($"{arrey[i]}  ");
            }
            Console.Write("\ncount: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\tНовый массив");
            int[] arrey2 = new int[count];
            for (int i = 0; i < arrey2.Length; i++)
            {
                if ((index + i) < N)
                {
                    arrey2[i] = arrey[index + i];
                    Console.Write($"{arrey2[i]}  ");
                }
                else
                {
                    arrey2[i] = 1;
                    Console.Write($"{arrey2[i]}  ");
                }
            }*/

            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            int[] arrey = new int[N];
            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i] = new Random().Next(100);
                Console.Write($"{arrey[i]}  ");
            }
            Console.Write("\ncount: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\tНовый массив");
            int[] arrey2 = new int[count];
            for (int i = 0; i < arrey2.Length; i++)
            {
                if ((index + i) < N)
                {
                    arrey2[i] = arrey[index + i];
                    Console.Write($"{arrey2[i]}  ");
                }
                else
                {
                    arrey2[i] = 1;
                    Console.Write($"{arrey2[i]}  ");
                }
            }
            //EndTask_4
            }
            

        }
    }

