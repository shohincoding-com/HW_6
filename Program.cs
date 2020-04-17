using System;
using System.Linq;

namespace HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_2
            Console.Write("Введите значение массива!!!\nN= ");
            int N;
            N = int.Parse(Console.ReadLine());
            int[] massiv = new int[N];

            for(int i=0; i<massiv.Length; i++){
                massiv[i] = i * i;
                Console.Write($"{massiv[i]} ");
            }

            Console.WriteLine($"\nМаксимальная значения массив = {massiv.Max()}");
            Console.WriteLine($"\nМинимальная значения массив = {massiv.Min()}");  
            Console.WriteLine($"\nСумма значеные массив = {massiv.Sum()}");  
            Console.WriteLine($"\nСредное арифметиеческое всех элементов = {massiv.Average()}"); 

            for(int i=1; i < massiv.Length; i++)
            {
                if(massiv[i] % 2 == 1)
                {
                    Console.Write($"{massiv[i]} ");
                }
            }      
            //EndTask_2

            //Task_3
            int[] massiv1 = new int [10];
            Console.WriteLine("\n\t\tМассив");
            
            for (int i = 0; i < massiv1.Length; i++)
            {
                massiv1[i] = i + i;
                Console.Write($"{massiv1[i]}  ");
            }
            Array.Reverse(massiv1);
            Console.WriteLine("\n\tМассив в обратном порядке!!!");
           
            for (int i = 0; i < massiv1.Length; i++)
            {
                Console.Write($"{massiv1[i]}  ");
            }
            // //EndTask_3

            // //Task_4
            Console.Write("\nВведите количество значеные массива!\nN = ");
            int N2 = int.Parse(Console.ReadLine());
            int[] massiv2 = new int[N2];
            
            for (int i = 0; i < massiv2.Length; i++)
            {
                massiv2[i] = i + i;
                Console.Write($"{massiv2[i]}  ");
            }
            
            Console.Write("\nВведите значение Count = ");
            int count = int.Parse(Console.ReadLine());
            
            Console.Write("Введите значение для Index = ");
            int index = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Новый массив");
            
            int[] massiv3 = new int[count];
            for(int i = 0; i < massiv3.Length; i++)
            {
                if ((index + i) < N2)
                {
                    massiv3[i] = massiv2[index + i];
                    Console.Write($"{massiv3[i]}  ");
                }
                else
                {
                    massiv3[i] = i*i;
                    Console.Write($"{massiv3[i]}  ");
                }

                
            }
            //EndTask_4
        
        }
    }

}

