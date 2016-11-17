using System;
using System.Linq;

namespace _14.IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/03.%20Methods/homework/14.%20Integer%20calculations/README.md
            decimal[] arr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            decimal[] result = new decimal[5];
            Calculate(arr, ref result);
            //print
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine("{0:F2}", result[2]); //average value should be with two digits of precision
            Console.WriteLine(result[3]);
            Console.WriteLine(result[4]);
        }

        static void Calculate(decimal[] arr, ref decimal[] result)
        {
            result[0] = arr.Min();
            result[1] = arr.Max();
            result[2] = arr.Average();
            result[3] = arr.Sum();
            result[4] = arr[0] * arr[1] * arr[2] * arr[3] * arr[4];
        }
    }
}
