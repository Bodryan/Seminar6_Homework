using System;

namespace Seminar6_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha41()
            {

                // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
                // 0, 7, 8, -2, -2 -> 2
                // 1, -7, 567, 89, 223-> 3

                Console.WriteLine("Сколько чисел необходимо ввести?");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[size];
                int count = 0;

                fillNums(array, size);
                Console.WriteLine("Вы ввели следующие числа:");
                printArray(array, size);

                Console.WriteLine();
                for (int i = 0; i < size; i++)
                {
                    if (array[i] > 0)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Количество цифр > 0 = {count}");
            }
            
            // Zadacha41();

            void Zadacha43()
            {
                // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
                // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

                Random random = new Random();

                Console.WriteLine("Введите значения прямой b1:");
                double b1 = Convert.ToDouble(Console.ReadLine());
                // double b1 = Math.Round(random.NextDouble() * 100, 2);
                Console.WriteLine("Введите значения прямой k1:");
                double k1 = Convert.ToDouble(Console.ReadLine());
                // double k1 = Math.Round(random.NextDouble() * 100, 2);
                Console.WriteLine("Введите значения прямой b2:");
                double b2 = Convert.ToDouble(Console.ReadLine());
                // double b2 = Math.Round(random.NextDouble() * 100, 2);
                Console.WriteLine("Введите значения прямой k2:");
                double k2 = Convert.ToDouble(Console.ReadLine());
                // double k2 = Math.Round(random.NextDouble() * 100, 2);
                
                Console.WriteLine($"Даны две прямые со значениями b1 = {b1}; k1 = {k1}; b2 = {b2}; k2 = {k2}");
                if (k1 == k2)
                {
                    Console.WriteLine("Прямые паралельны");
                }
                else
                {
                    double x = Math.Round((b2 - b1) / (k1 - k2), 1);
                    Console.WriteLine($"Координата x = {x}");
                    double y1 = Math.Round((k1 * x + b1), 1);
                    Console.WriteLine($"Координата y1 = {y1}");
                    double y2 = Math.Round((k2 * x + b2), 1);
                    Console.WriteLine($"Координата y2 = {y2}");
                }

            }

            Zadacha43();
            



        }

        static void fillNums(int[] array,int size)
        {   

            for (int i = 0; i < size; i++)
            {
                Console.Write($"{i + 1} число = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }


        static void printArray(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
        }


    }

}