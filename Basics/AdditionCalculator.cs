// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Fardad!");


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

//string Concatenation
Console.WriteLine("The sum of "+ myNumber + " and " + myNumber2 + " is " + (myNumber + myNumber2));


//string interpolation
Console.WriteLine($"The sum of {myNumber} and {myNumber2} is {myNumber + myNumber2}");


Console.ReadKey(); 