// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, Fardad");



Console.WriteLine("Enter the first number number:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Choose an Operation: +, -, *, /");
string operation = Console.ReadLine();
if (operation == "/" && num2 == 0) Console.WriteLine("Error: Division by zero is not allowed.");
else
{
    switch (operation)
    {
        case "+":
            Console.WriteLine("Result: " + (num1 + num2));
            break;
        case "-":
            Console.WriteLine("Result: " + (num1 - num2));
            break;
        case "*":
            Console.WriteLine("Result: " + num1 * num2);
            break;
        case "/":
            Console.WriteLine("Result: " + num1 / num2);
            break;
        default:
            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            break;


    }
}

Console.ReadKey();