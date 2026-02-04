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

        if (!Calculator.TryCompute(num1, num2, op, out double result))
        {
            Console.WriteLine("Invalid operator!");
            return;
        }

        Console.WriteLine($"Result: {result}");
    }
}

public static class Calculator
{
    public static bool TryCompute(double left, double right, char op, out double result)
    {
        switch (op)
        {
            case '+':
                result = left + right;
                return true;
            case '-':
                result = left - right;
                return true;
            case '*':
                result = left * right;
                return true;
            case '/':
                result = right != 0 ? left / right : double.NaN;
                return true;
            default:
                result = 0;
                return false;
        }
    }
}
