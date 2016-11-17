using System;
using System.Numerics;

namespace _10.NFactorial
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/03.%20Methods/homework/10.%20N%20Factorial/README.md
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            NFactorial(n, ref factorial);
            Console.WriteLine(factorial);
        }

        static void NFactorial(int n, ref BigInteger factorial)
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
        }
    }
}
