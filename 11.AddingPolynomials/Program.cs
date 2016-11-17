using System;
using System.Linq;

namespace _11.AddingPolynomials
{
    class Program
    {
        static int n;
        static int[] firstValues;
        static int[] secondValues;
        static int[] firstPolynomials;
        static int[] secondPolynomials;
        static string[] result;

        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/03.%20Methods/homework/11.%20Adding%20polynomials/README.md
            n = int.Parse(Console.ReadLine());
            firstValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            secondValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            firstPolynomials = new int[n];
            secondPolynomials = new int[n];
            result = new string[n];
            //calculation
            PolinomialsCalc();
            //print
            Console.WriteLine(string.Join(" ", result));
        }

        static void PolinomialsCalc()
        {

            //first Polynomials  (example input: 5 0 1 => x2 + 5 = 1x^2 + 0x + 5 => {5, 0, 1} )
            for (int i = 0; i < n; i++)
            {
                firstPolynomials[i] = firstValues[n - i - 1];
            }
            //secondPolynomials  (example input: 7 4 -3 => -3x2 + 4x + 7 = -3x2 + 4x + 7 => {7, 4, -3} )
            for (int i = 0; i < n; i++)
            {
                secondPolynomials[i] = secondValues[n - i - 1];
            }
            //calculation polynomials
            for (int i = 0; i < n; i++)
            {
                result[n - i - 1] = (firstPolynomials[i] + secondPolynomials[i]).ToString();
            }
        }
    }
}
