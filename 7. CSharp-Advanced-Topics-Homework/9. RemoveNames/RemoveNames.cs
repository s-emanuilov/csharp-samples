using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        //Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. 
        Console.Title = "ConsoleApp - Remove Names";
        List<string> firstInput = new List<string> { "Hristo", "Hristo", "Nakov", "Nakov", "Petya" };
        List<string> secondInput = new List<string> { "Nakov", "Vanessa", "Maria" };
        List<string> resultNames = new List<string>();

        for (int i = 0; i < firstInput.Count; i++)
        {
            int counter = 0;
            for (int j = 0; j < secondInput.Count; j++)
            {
                if (!(firstInput[i] == secondInput[j]))
                {
                    counter++;
                }
            }
            if (counter==secondInput.Count)
            {
                resultNames.Add(firstInput[i]);
            }
        }
        foreach (var name in resultNames)
        {
            Console.Write("{0} ",name);
        }
        Console.ReadLine();
    }
}
