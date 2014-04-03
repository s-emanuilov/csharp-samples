using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        //Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. 
        Console.Title = "ConsoleApp - Join Lists";
        List<int> firstInput = new List<int> { 5, 4, 3, 2, 1, 5 };
        List<int> secondInput = new List<int> { 6, 3, 2, 6, 6, 6, 7, 8 };
        List<int> resultInt = firstInput;
        for (int i = 0; i < secondInput.Count; i++)
        {
            resultInt.Add(secondInput[i]);
        }
        resultInt.Sort();
        for (int j = 0; j < resultInt.Count - 1; j++)
        {
            if (resultInt[j] == resultInt[j + 1])
            {
                resultInt.RemoveAt(j);
                j--;
            }
        }

        foreach (var number in resultInt)
        {
            Console.Write("{0} ", number);
        }
        Console.ReadLine();
    }
}

