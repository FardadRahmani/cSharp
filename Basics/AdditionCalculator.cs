// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//takes user input and stores it





int myNumber = 0;
int myNumber2 = 0;
//myNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a whole number:");
string userInput = Console.ReadLine();
myNumber = int.Parse(userInput);

Console.WriteLine("Enter another whole number:");
userInput = Console.ReadLine();
myNumber2 = int.Parse(userInput);

Console.WriteLine("The sum is: " + (myNumber + myNumber2));





Console.ReadKey(); 