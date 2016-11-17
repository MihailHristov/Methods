using System;


namespace _03.EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/03.%20Methods/homework/03.%20English%20digit/README.md
            int input = int.Parse(Console.ReadLine());
            string lastDigit = LastDigitAsWord(input);
            Console.WriteLine(lastDigit);
        }

        static string LastDigitAsWord(int input)
        {
            string tempWord = null;
            int temp = 0;
            temp = input % 10;

            switch (temp)
            {
                case 0: tempWord = "zero"; break;
                case 1: tempWord = "one"; break;
                case 2: tempWord = "two"; break;
                case 3: tempWord = "three"; break;
                case 4: tempWord = "four"; break;
                case 5: tempWord = "five"; break;
                case 6: tempWord = "six"; break;
                case 7: tempWord = "seven"; break;
                case 8: tempWord = "eight"; break;
                case 9: tempWord = "nine"; break;
            }
            return tempWord;
        }
    }
}
