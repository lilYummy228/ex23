using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int minRandomValue = 0;
            int maxRandomValue = 10;
            int tempNumber;
            Random random = new Random();
            Console.WriteLine("Обычный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minRandomValue, maxRandomValue);
                Console.Write($"{array[i]}|");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        tempNumber = array[i];
                        array[i] = array[j];
                        array[j] = tempNumber;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}|");
            }
        }
    }
}
