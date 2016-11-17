using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/03.%20Methods/homework/09.%20Sorting%20array/README.md
            int size = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Sorting(size, arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static void Sorting(int size, int[] arr)
        {
            int tempMaxValueIndex = 0;
            int tempMaxValue = 0; //eventualno na -1

            for (int element = 0; element < size; element++)
            {
                for (int currentElement = 0; currentElement < size - element; currentElement++)
                {
                    CatchMaxVlue(arr, ref tempMaxValueIndex, ref tempMaxValue, currentElement);
                }
                ParseMaxAtLastButOnePosition(arr, size, element, ref tempMaxValueIndex, ref tempMaxValue);
            }
        }

        static void CatchMaxVlue(int[] arr, ref int tempMaxValueIndex, ref int tempMaxValue, int currentElement)
        {
            if (arr[currentElement] > tempMaxValue)
            {
                tempMaxValue = arr[currentElement];
                tempMaxValueIndex = currentElement;
            }
        }

        static void ParseMaxAtLastButOnePosition(int[] arr, int size, int element, ref int tempMaxValueIndex, ref int tempMaxValue)
        {
            int temp = 0;
            //backup value
            temp = arr[size - element - 1];
            //parse max value
            arr[size - element - 1] = tempMaxValue;
            //parse backed up value to new position
            arr[tempMaxValueIndex] = temp;

            //reset values
            tempMaxValueIndex = 0;
            tempMaxValue = 0;
        }
    }
}

//Модифициран вариянт на сортиращия алгоритъм "Метода на балончето" с лека оптимизация