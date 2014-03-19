using System;

class ChangeBit
{
    static void Main()
    {
        //We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. 
        Console.Title = "ConsoleApp - Change bit at give position";
        Console.WriteLine("Please give a number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please give a bit value (must be 1 or 0):");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a position:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        if (v==1)
        {
            Console.WriteLine("Input: {0}", n);
            Console.WriteLine("Output: {0}", n|mask);
        }
        else if (v==0)
        {
            Console.WriteLine("Input: {0}", n);
            Console.WriteLine("Output: {0}", n&(~mask) );
        }
        else
        {
            Console.WriteLine("Bit value must be 0 or 1! You have entered something different.");
        }
        Console.ReadLine();
    }
}
