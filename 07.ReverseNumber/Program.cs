using System;

namespace _07.ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/03.%20Methods/homework/07.%20Reverse%20number/README.md
            char[] input = Console.ReadLine().ToCharArray();
            string reversedNumber = null;
            Revers(input, ref reversedNumber);
            Console.WriteLine(reversedNumber);
        }

        static void Revers(char[] input, ref string reversedNumber)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedNumber = reversedNumber + input[i];
            }
        }
    }
}
