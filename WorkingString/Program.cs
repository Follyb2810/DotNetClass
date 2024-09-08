using System;
using System.Collections.Generic; // Required for List<T>

public class Program
{
    public static void Main(string[] args)
    {
        string Lname = "folly";
        string Fname = "babs";
        string[] Food = { "mango", "paw paw" };
        List<string> CoFunders = new List<string> { "folly", "remi", "akin" }; 

        Console.WriteLine($"Your first name is {Fname} and last name is {Lname}");
        Console.WriteLine(Fname.IndexOf("l"));

        // Display all foods
        Console.Write("All food items: ");
        foreach (string item in Food)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        // Display single food item
        Console.WriteLine($"{Food[0]} is a single food item.");
        Console.WriteLine($"All food items: {string.Join(", ", Food)}");

        // Modify CoFunders list
        CoFunders.Add("bello");
        CoFunders.Add("mahmud");
        CoFunders.Remove("babs");

        // Display list of co-founders
        Console.WriteLine("List of co-founders:");
        for (int i = 0; i < CoFunders.Count; i++) // Corrected loop condition and variable name
        {
            Console.WriteLine($"Co-founder at position {i}: {CoFunders[i]}");
        }

        // Check if "folly" is in CoFunders list
        bool isFolly = CoFunders.Contains("folly");
        if (isFolly)
        {
            Console.WriteLine("Folly is among the co-funders");
        }
        else
        {
            Console.WriteLine("Folly is not among the co-funders");
        }

        // Display all co-founders again
        Console.WriteLine("All co-founders:");
        Console.WriteLine(string.Join(", ", CoFunders));
    }
}
