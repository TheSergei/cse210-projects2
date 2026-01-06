using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();        //make a new list 

        int userNumber = -1;        //make sure this is less than 0 or else the program wont prompt user

        while (userNumber != 0)     // generate while loop carefully
        {
            Console.Write("Enter a number, (0 to quit): ");
            
            string userResponse = Console.ReadLine();       // this is the key to not have an infinite loop!!!!!!
            userNumber = int.Parse(userResponse);

            if (userNumber > 0)
            {
                numbers.Add(userNumber);        //add input into list
            }
        }

        int listSum = numbers.Sum();
        Console.WriteLine($"the sum is {listSum}");     //compute sum of all numbers using LINQ

        
        
        double avg = numbers.Average();     //compute avg using LINQ
        Console.WriteLine($"the avg is {avg}");
        

        int max = numbers.Max();        //compute max or largest number in the list using LINQ
        Console.WriteLine($"the max is {max}");
    }

}