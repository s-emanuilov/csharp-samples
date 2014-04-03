using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the number \"n\":");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter a number:");
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        numbers.Sort();
        Console.Write("Numbers sorted: ");
        foreach (var number in numbers)
        {
            Console.Write("{0} ", number);
        }
        Console.ReadLine();
    }
}

