// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, Fardad");

Random random = new Random();

int secretNumber = random.Next(1, 101);
int userGuess = 0;
int counter = 0;



while (userGuess != secretNumber)
{
    counter++;
    Console.WriteLine("Enter your Guess");
    userGuess = int.Parse(Console.ReadLine());

    if (userGuess < secretNumber)
    {
        Console.WriteLine("Too Low! Try again.");

    } else if (userGuess > secretNumber)
    {
        Console.WriteLine("Too High! Try again.");
        
    } else
    {
        Console.WriteLine("Correct! Well Done! It took you " + counter + " tries.");
    }
}


Console.ReadKey();