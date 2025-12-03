using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Bob", "Steve", "Nina" };
            int[] numbers = new int[] { 5, 57, 87, 1, 150, 32, 14 };
            foreach (string name in names)
                Console.WriteLine($"Goodbye {name}");

            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.WriteLine($"{num}");
            }
            Array.Clear(numbers,6, 1 );
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            
               
            
        }
    }
}
