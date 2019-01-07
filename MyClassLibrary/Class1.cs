using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Class1
    {
        public string Greeting(string greet, string name) {
            var greeting = greet + ", " + name;
            return greeting;
        }
        public int SumOfTwoIntegers(int num1, int num2) {

            var sum = num1 + num2;
            return sum;
        }
        public decimal QuotientOfTwoIntegers(decimal num1, decimal num2) {
            var quotient = num1 / num2;
            return quotient;
        }
        public int[] SwapTwoInteger(int[] numArray) {
            var temp = numArray[0];
            numArray[0] = numArray[1];
            numArray[1] = temp;
            return numArray;
        }
        public int ProductOfThreeIntegers(int num1, int num2, int num3) {
            var product = num1 * num2 * num3;
            return product;

        }
        public decimal ComputeAverage(List<int> list) {
            var sum = ComputeSum(list);
            var average = sum / list.Count;
            return average;
        }
        public int ComputeSum(List<int> list) {
            var sum = 0;
            foreach (int item in list) {
                sum += item;
            }
            return sum;
        }
    }
}
