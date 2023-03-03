using System;

namespace Anonim_Metod_21._02._2023HM
{
    delegate void Mydeleg1(int[] arr);
    delegate void MyDelegat2(int[] mass);

    class Swap
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            Random rand = new Random();
            Mydeleg1 obj = (int[] arr) =>
            {
                int Count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1, 20);
                    Console.Write(arr[i] + "\t");
                    if (arr[i] % 7 == 0)
                    {
                        Count++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Числа, кратные 7: {Count}");
            };
            obj(arr);
            Console.WriteLine();


            int[] mass = new int[6];
            MyDelegat2 obj1 = (int[] mass) =>
            {
                int Counter = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rand.Next(-10, 10);
                    Console.Write(mass[i] + "\t");
                    if (mass[i] > 0)
                    {
                        Counter++;
                    }

                }
                Console.WriteLine($"Количесвто положительных чисел: {Counter}");
                Console.WriteLine();
            };
            obj1(mass);

            Console.WriteLine("\n");
            MyDelegat2 obj2 = (int[] mass) =>
            {
                int Count = 0;
                for (int i = 0; i < mass.Length; i++)
                {

                    Console.Write(mass[i] + "\t");
                    if (mass[i] < 0)
                    {
                        Count++;
                    }
                }
                Console.WriteLine($"Количесвто отрицательных чисел: {Count}");
                Console.WriteLine();
            };
            obj2(mass);


            Console.WriteLine();
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Mydeleg1 obj3 = (int[] arr) =>
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1, 20);
                    Console.Write(arr[i] + "\t");
                    if (a == arr[i])
                    {
                        Console.WriteLine("Число равняется числу в массиве");
                    }
                    else
                    {
                        Console.WriteLine("Число не равняется числу в массиве");
                    }
                }
                Console.WriteLine();
            };
            obj3(arr);



        }
    }
}

