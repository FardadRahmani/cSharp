// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, Fardad");

string rocket = "        |\n       /\\\n      /  \\\n     /    \\\n    /      \\\n   /        \\\n  /__________\\\n  |          |\n  |          |\n  |          |\n  |          |\n /            \\\n/______________\\\n";



//Countdown

for (int i = 5; i >= 0; i--)
{
    Console.Clear();
    Console.WriteLine("Time remaining: " + i + " seconds" );
    Console.WriteLine(rocket);
    rocket = "\r\n" + rocket;
    Thread.Sleep( 1000 );
}
Console.WriteLine("The rocket has landed successfully! Yoohoo!");


Console.ReadKey();