using System;
using System.Linq;

namespace _06.FirstLargerThanNeighbours
{
    class Program
    {
        static int indexOfFirstElement;

        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/03.%20Methods/homework/06.%20First%20larger%20than%20neighbours/README.md
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            CheckNeighbours(n, arr);
            Console.WriteLine(indexOfFirstElement);
        }

        static void CheckNeighbours(int n, int[] arr)
        {
            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                {
                    indexOfFirstElement = i;
                    break;
                }
            }

            if (indexOfFirstElement == 0)
            {
                indexOfFirstElement = -1;
            }
        }
    }
}