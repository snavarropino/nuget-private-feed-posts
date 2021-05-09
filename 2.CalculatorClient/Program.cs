using System;
using Serginet.Calculator;

namespace CalculatorClient
{
    static class Program
    {
        static void Main()
        {
            var a = 5;
            var b = 7;
            var calculator = new Calculator();


            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a + b = {calculator.Add(a,b)}");
            Console.WriteLine($"a - b = {calculator.Subtract(a, b)}");
            Console.WriteLine($"a * b = {calculator.Multiply(a, b)}");
            Console.WriteLine($"a / b = {calculator.Divide(a, b)}");
        }
    }
}
