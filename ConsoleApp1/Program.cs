using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static Class1 c1 = new Class1();

        static void Main(string[] args)
        {
            DisplayAverage();

            Console.ReadKey();
        }
        public static void DisplayGreeting() {
            var greet = "Hello";
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine(c1.Greeting(greet, name));
        }
        public static void DisplaySumOfTwoIntegers() {
            Console.Write("Enter first integer: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            var sum = c1.SumOfTwoIntegers(num1, num2);
            Console.WriteLine("Sum: " + sum.ToString());
        }
        public static void DisplayQuotientOfTwoIntegers() {
            Console.Write("Enter first integer: ");
            var num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter second integer: ");
            var num2 = Convert.ToDecimal(Console.ReadLine());
            var quotient = c1.QuotientOfTwoIntegers(num1, num2);
            Console.WriteLine("Quotient: " + quotient.ToString("F"));
        }
        public static void DisplaySwapTwoInteger() {
            var numArray = new int[2];
            Console.WriteLine("Swapping Two Integer");

            Console.WriteLine("Input");
            Console.Write("Enter first integer: ");
            numArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            numArray[1] = Convert.ToInt32(Console.ReadLine());

            numArray = c1.SwapTwoInteger(numArray);

            Console.WriteLine("Output");
            Console.WriteLine("First integer: " + numArray[0]);            
            Console.WriteLine("Second integer: " + numArray[1]);
        }
        public static void DisplayProductOfThreeIntegers() {
            Console.Write("Enter first integer: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third integer: ");
            var num3 = Convert.ToInt32(Console.ReadLine());
            var quotient = c1.ProductOfThreeIntegers(num1, num2, num3);
            Console.WriteLine("Product: " + quotient.ToString());
        }
        public static void DisplayArithmeticOperations() {
            Console.Write("Enter first integer: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum: " + (num1 + num2).ToString());
            Console.WriteLine("Difference: " + (num1 - num2).ToString());
            Console.WriteLine("Product: " + (num1 * num2).ToString());
            Console.WriteLine("Quotient: " + (num1 / num2).ToString("F"));
            Console.WriteLine("Modulus: " + (num1 % num2).ToString());
        }
        public static void DisplayMultiplicationColumn() {
            Console.Write("Enter number: ");
            var num = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i <= 10; i++) {
                Console.WriteLine(num.ToString() + " * " + i.ToString() + " = " + (num * i).ToString());
            }
        }
        public static void DisplayAverage() {
            var list = new List<int>();
            Console.Write("Enter first number: ");
            list.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter second number: ");
            list.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter third number: ");
            list.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter fourth number: ");
            list.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Average: " + c1.ComputeAverage(list));
        }
    }
}
