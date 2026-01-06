using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade-");
        string UserInput = Console.ReadLine();
        int grade = int.Parse(UserInput);
        if (grade >= 93)
        {
            Console.WriteLine("you have an A!");
        }
        else if (grade >= 90 && grade < 93)
            {
                Console.WriteLine("you have an A-!");
            }
        else if (grade >= 87 && grade < 90)
            {
                Console.WriteLine("you have a B+!");
            }
        else if (grade >= 83 && grade < 87)
            {
                Console.WriteLine("you have a B!");
            }
        else if (grade >= 80 && grade < 83)
            {
                Console.WriteLine("you have a B-!");
            }
        else if (grade >= 77 && grade < 80)
            {
                Console.WriteLine("you have a C+!");
            }
        else if (grade >= 73 && grade < 77)
            {
                Console.WriteLine("you have a C!");
            }
        else if (grade >= 70 && grade < 73)
            {
                Console.WriteLine("you have a C-!");
            }
        else if (grade >= 67 && grade < 70)
            {
                Console.WriteLine("you have a D+!");
            }
        else if (grade >= 63 && grade < 67)
            {
                Console.WriteLine("you have a D!");
            }
        else if (grade >= 60 && grade < 63)
            {
                Console.WriteLine("you have a D-!");
            }
        else
        {
            Console.WriteLine("You have an F!");
        }
    }
}
