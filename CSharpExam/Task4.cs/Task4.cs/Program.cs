using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = Add(num1, num2);
            int difference = Subtract(num1, num2);
            int product = Multiply(num1, num2);
            double quotient = Divide(num1, num2);

            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The difference of the numbers is: {difference}");
            Console.WriteLine($"The product of the numbers is: {product}");
            Console.WriteLine($"The quotient of the numbers is: {quotient}");

            Console.ReadLine();
        }

        static int Add(int num1, int num2)
        {
            return  num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }


        static int Multiply(int num1, int num2)
        {
            return num1  * num2;
        }

        static double Divide(double num1, double num2)
        {
            return num1  /  num2;
        }
    
    }
}
