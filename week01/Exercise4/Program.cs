using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis; // If you need to add a list in your program you need to add the library first
using System.Linq; // Library added to do the sum of the numbers and other operations 

class Program
{
    static void Main(string[] args)
    {
        // List<string> words= new List<string>();

        // words.Add("Phone");
        // words.Add("Keyboard");
        // words.Add("Mouse");

        // Console.WriteLine(words.Count);
        
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console. WriteLine(words[i]);
        // }

        List<int> numbers= new List<int>();
        int input;

        do
        {
            Console.Write("Write a number to add in the List: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0) // Add the number if different from zero
            {
                numbers.Add(input);
            }

        } while (input != 0);


        Console.WriteLine("The numbers added to the list are: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        //// CORE REQUIREMENTS ////
        int total = numbers.Sum();
        

        // int length = numbers.Count;
        // double average = (double)total / length;  // This is a basic logic to find the average number

        double average =numbers.Average(); // This is the code using the LINQ Library

        int biggest = numbers.Max();

        // Console.WriteLine($"The length of your list is {length}.");
        Console.WriteLine($"The sum of the informed numbers is {total}.");
        Console.WriteLine($"The average numbers is {average}.");
        Console.WriteLine($"The largest number is {biggest}.");

        
        //// STRETCH REQUIREMENTS ////
        int smallestPositive = numbers.Where(n => n > 0).Min(); // Here it is used the LINQ Library

        Console.WriteLine($"The smallest positive number is {smallestPositive}.");

        numbers.Sort(); // Using Sort command from LINQ Library to organize the list before print it out
        Console.WriteLine("List in ascending order: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}