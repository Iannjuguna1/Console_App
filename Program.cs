using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter operator (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine() ?? "0");

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num2 != 0 ? num1 / num2 : double.NaN;
                break;
            default:
                Console.WriteLine("Invalid operator!");
                return;
                
        }

        Console.WriteLine($"Result: {result}");
    }
}
