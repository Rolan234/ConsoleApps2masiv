using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Задача 1 
            //int[] array = new int[6];
            //for (int i = 0; i < 6; i++)  // последовательно
            //{
            //    Console.WriteLine($"array [{i}] = ");
            //    array[i] = int.Parse(Console.ReadLine() );
            //}
            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine($"array[{i}] = {array[i]}");
            //}

            // Задача 2

            //int[] array = new int[31];
            //Random random = new Random();
            //for (int i=0; i<array.Length; i++)
            //{
            //    array[i] = random.Next(5, 60);
            //    Console.WriteLine($"array [{i}]= {array[i]}");
            //}
            //int summ = 0;
            //for (int i=0; i< array.Length; i++)
            //{
            //    summ += array[i];
            //}
            //Console.WriteLine($"Общее кол-во осадков = {summ}");

            // Задача 3

            {
             double[] weights = new double[20]
                Random rnd = new Random(); 
                for (int i = 0; i < 20; i++)
                {
                    weights[i] = rnd.NextDouble() * (100 - 50) + 50;
                }
                double averageWeight = 0; 
                for (int i = 0; i < 20; i++)
                {
                    averageWeight += weights[i];
                }
                averageWeight /= 20;

                Console.WriteLine("Средний вес: " + averageWeight);
            }
        }
       
        }   
    }
}
