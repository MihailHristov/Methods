using System;
using System.Linq;


namespace _02.GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/03.%20Methods/homework/02.%20Get%20largest%20number/README.md
            int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxNumb = GetMax(values);
            Console.WriteLine(maxNumb);
        }

        static int GetMax(int[] values)
        {
            int temp = int.MinValue;
            for (int i = 0; i < values.Length; i++)
            {
                if (temp < values[i])
                {
                    temp = values[i];
                }
            }
            return temp;
        }
    }
}
