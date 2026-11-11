//one must always write a simple calculator when learning a new language
using System;

namespace HelloWorld
{
    class Program
    {
        static double sum(double a, double b){
            
            return a + b;
        }

        static double subtract(double a, double b){
            return a - b;
        }

        static double multiply(double a, double b){
            return a * b;
        }

        static double divide(double a, double b){
            if (b == 0){
                return 0;
            }
            return a / b;
        }

        static double remainder(double a, double b){
            if (b == 0){
                return 0;
            }
            return a % b;
        }

        static void Main(string[] args){
            double num1 = 0, num2 = 0;
            int operation = 0;
            double result = 0;

            Console.Write("Insert the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the operation:");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Division Remainder");
            operation = Convert.ToInt32(Console.ReadLine());

            switch(operation){
                case 1:
                    result = sum(num1,num2);
                    break;
                case 2:
                    result = subtract(num1,num2);
                    break;
                case 3:
                    result = multiply(num1,num2);
                    break;
                case 4:
                    result = divide(num1,num2);
                    break;
                case 5:
                    result = remainder(num1,num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation. Ending world.");
                    break;
            }
            Console.WriteLine("Result is: " + result);
        }
    }
}