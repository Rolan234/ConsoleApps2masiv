using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1 
            int[] array = new int[6];
            for (int i = 0; i < 6; i++)  // последовательно
            {
                Console.WriteLine($"array [{i}] = ");
                array[i] = int.Parse(Console.ReadLine() );
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
        }
            Console.Read();
    }
}
