using System;
using System.Collections.Generic;
using System.Linq;

class CountLetters
{
    static void Main()
    {
        //Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order. Use the input and output format from the examples below. 
        Console.Title = "ConsoleApp - Count of letters";
        List<char> inputChars = new List<char> { 'h', 'd', 'h', 'a', 'a', 'a', 's', 'd', 'f', 'd', 'a', 'd', 'j', 'd', 's', 'h', 'a', 'a' };
        Dictionary<char, int> elements = new Dictionary<char, int>();
        for (int i = 0; i < inputChars.Count; i++)
        {
            int counter = 1;
            if (!elements.ContainsKey(inputChars[i]))
            {
                elements.Add(inputChars[i], counter);
            }
            else
            {
                elements[inputChars[i]] += 1;
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

