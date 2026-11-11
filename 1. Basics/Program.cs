using System;

namespace HelloWorld
{
    class Program //Class name therefore file name, like Java!
    {
        static string StringReturn()
        {
            // int, double, float, long, char, bool, string. same old friends 
            string placeholder = "How";
            placeholder += "dy from another ";

            const string importantWord = "method!";
            placeholder += importantWord;
            return placeholder;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); //cout with endl
            Console.Write("Goodbye,");          //cout without endl
            Console.WriteLine(" World!");       //cout with endl

            Console.WriteLine(StringReturn());
        }
    }
}