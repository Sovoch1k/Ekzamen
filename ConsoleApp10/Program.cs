using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 7, 9, 8, 9, 10, 11, 12 };
            int min = arr[0];
            bool Found = false;
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Found = true;
                    break;
                }
                else if (arr[i] <min)
                {
                    min = arr[i];
                }

            }
            if(Found)
            {
              Console.WriteLine($"Мин значение до первого чётного: {min}");
            }
            else 
            {
                Console.WriteLine("Чётный элемент не найден");   
            }

           

            Console.ReadLine();
        }
    }
}
