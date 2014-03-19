using System;

class ExtractBit
{
    static void Main()
    {
        //Write an expression that extracts from given integer n the value of given bit at index p. 
        Console.Title = "ConsoleApp - Extract bit";
        Console.WriteLine("Please give a number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a position:");
        int p = int.Parse(Console.ReadLine());
        string numBitwise = Convert.ToString(n, 2);
        int nRight = n >> p;
        if ((nRight & 1) == 1)
        {
            Console.WriteLine("The bit on position {0} in the number {1} (bitwise: {2}) is 1", p, n, numBitwise);
        }
        else
        {
            Console.WriteLine("The bit on position {0} in the number {1} (bitwise: {2}) is 0", p, n, numBitwise);
        }
        Console.ReadLine();
    }
}

