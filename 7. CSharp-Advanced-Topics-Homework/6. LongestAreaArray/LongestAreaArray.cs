using System;
using System.Collections.Generic;
using System.Linq;

class LongestAreaArray
{
    static void Main()
    {
        //Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them. 
        Console.WriteLine("Please enter the number \"n\":");
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> elements = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            int counter = 1;
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();
            if (!elements.ContainsKey(input))
            {
                elements.Add(input, counter);
            }
            else
            {
                elements[input] += 1;
            }
        }
        Console.WriteLine(elements.Values.Max());
        for (int i = 0; i < elements.Values.Max(); i++)
        {
            var key = elements.FirstOrDefault(x => x.Value == elements.Values.Max()).Key;
            Console.WriteLine(key);
        }

        Console.ReadLine();
    }


}

