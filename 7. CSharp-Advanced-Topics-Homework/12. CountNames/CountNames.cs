using System;
using System.Collections.Generic;
using System.Linq;
class CountNames
{
    static void Main()
    {
        //Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order. Use the input and output format from the examples below. 
        Console.Title = "ConsoleApp - Count of names";
        List<string> inputNames = new List<string> { "Peter", "Steve", "Nakov", "Steve", "Alex", "Nakov" };
        Dictionary<string, int> elements = new Dictionary<string, int>();
        for (int i = 0; i < inputNames.Count; i++)
        {
            int counter = 1;
            if (!elements.ContainsKey(inputNames[i]))
            {
                elements.Add(inputNames[i], counter);
            }
            else
            {
                elements[inputNames[i]] += 1;
            }
        }
        var listOfKeys = elements.Keys.ToList();
        listOfKeys.Sort();
        foreach (var key in listOfKeys)
        {
            Console.WriteLine("{0} => {1}", key, elements[key]);
        }
        Console.ReadLine();
    }
}

