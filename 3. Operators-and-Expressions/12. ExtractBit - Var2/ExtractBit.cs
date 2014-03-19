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
        string stringForCheck = Convert.ToString(n, 2);
        if (stringForCheck.Length <= p)
        {
            stringForCheck = new string('0', (p - stringForCheck.Length) + 1) + stringForCheck;
        }
        bool isOne = stringForCheck[stringForCheck.Length-p-1] == '1';
        Console.WriteLine("The bit on position {0} in the number {1} (bitwise: {2}) is 1? : {3}", p, n, stringForCheck, isOne);
        Console.ReadLine();
    }

}


