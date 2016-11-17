using System;


namespace _01.SayHello
{
    class Program
    { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/03.%20Methods/homework/01.%20Say%20Hello/README.md
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            PrintName(inputName);
        }

        static void PrintName(string inputName)
        {
            string concatStrings = "Hello, " + inputName + "!";
            Console.WriteLine(concatStrings);
        }

    }
}
