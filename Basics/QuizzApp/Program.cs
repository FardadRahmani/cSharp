﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string question1 = "What is the Capital of Germany";
string answer1 = "Berlin";

string question2 = "What is 2 + 2";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow";
string answer3 = "Green";


int score = 0;

Console.WriteLine(question1);
string userAnswer = Console.ReadLine();

if (userAnswer == answer1)
{
    Console.WriteLine("Correct!");
    score += 1;
} 
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer1);
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();

if (userAnswer2 == answer2)
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer2);
}


Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();

if (userAnswer3 == answer3)
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer3);
}

Console.WriteLine($"Your final score is {score}/3!");

if (score == 3) Console.WriteLine("You got'em all right");

Console.ReadKey();