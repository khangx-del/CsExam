using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a double :");
            double number2 = Convert.ToDouble(Console.ReadLine());
            float num = 5.75f;
            Console.Write("Enter a string :");
            string input = Console.ReadLine();

            Console.WriteLine($"{number}");
            
            Console.WriteLine($"{number2}");
            Console.WriteLine($"{num}");
            Console.WriteLine($"{input}");
            Console.WriteLine("int using for number");
            Console.WriteLine("double using for decimal");
            
            Console.WriteLine("float using for decimal values with an f");
            
            Console.WriteLine("string is for words");



        }
    }
}
