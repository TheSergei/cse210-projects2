using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);     //generate random number

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());          //do not forget to parse string into int 

            if (guess > magicNumber)
            {
                Console.WriteLine("too high");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("too low");
            }
            else
            {
                Console.WriteLine("you got it!");           //if statements
            }
        }
    }
}