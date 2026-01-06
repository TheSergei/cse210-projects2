using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Display();
        string promptName = UserName();
        int promptNumber = FavoriteNumber();
        int squaredNumber = Square(promptNumber);
        Console.WriteLine($"{promptName}, the square of your number is {squaredNumber}");
    }
    static void Display()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string UserName()
    {
        Console.WriteLine("enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int FavoriteNumber()
    {
        Console.WriteLine("enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int Square(int number)
    {
        int squared = number * number;

        return squared;
    }
}
