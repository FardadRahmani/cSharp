// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, Fardad");



//Create instance of Random Class
Random random = new Random();
int randomNumber = random.Next(1, 11); //gives us number between 1 and 10


Console.WriteLine("Enter a number:");

string inputString = Console.ReadLine();
int num1;
bool isNumber = int.TryParse(inputString, out num1);
num1++;

if(isNumber)
{
    if(num1 == randomNumber)
    {
        Console.WriteLine("You guessed right!");
    }
    else
    {
        Console.WriteLine("You guessed wrong, try again!");
    }
    Console.WriteLine("You entered a number");
}
else
{
    Console.WriteLine("Haha Invalid input. You did not enter a number.");
}






Console.ReadKey();