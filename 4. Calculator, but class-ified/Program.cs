//you get it??? because im using Classes, so it's Class-ified
using System;

namespace HelloWorld
{
    public class Calculator
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Unable to divide by zero");
            }
            return a / b;
        }

        public double Remainder(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Unable to divide by zero");
            }
            return a % b;
        }
    }
    class Program
    {
       static double ValidateNumber()
        {
            double number = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out number))
                {
                    return number;
                }
                Console.WriteLine("Invalid number. Try again.");
            }
        }

        static void Main(string[] args){

            var calc = new Calculator();
            double num1 = 0, num2 = 0;
            int operation = 0;
            double result = 0;

            Console.Write("Insert the first number: ");
            num1 = ValidateNumber();

            Console.Write("Insert the second number: ");
            num2 = ValidateNumber();

            Console.WriteLine("Choose the operation:");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Division Remainder");
            operation = Convert.ToInt32(Console.ReadLine());

            switch(operation){
                case 1:
                    result = calc.Sum(num1,num2);
                    break;
                case 2:
                    result = calc.Subtract(num1,num2);
                    break;
                case 3:
                    result = calc.Multiply(num1,num2);
                    break;
                case 4:
                    result = calc.Divide(num1,num2);
                    break;
                case 5:
                    result = calc.Remainder(num1,num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation. Ending world.");
                    break;
            }
            Console.WriteLine("Result is: " + result);
        }
    }
}