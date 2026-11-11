//I don't want inputs meddling with my "1. Basics" code
using System;

namespace HelloWorld
{
    class Program //Class name therefore file name, like Java!
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello what?"); //cout with endl
            string userInput = Console.ReadLine();

            Console.WriteLine("Hello, " + userInput + "!");
        }
    }
}