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
        char v = char.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a position:");
        int p = int.Parse(Console.ReadLine());
        string stringForCheck = Convert.ToString(n, 2);
        if (stringForCheck.Length <= p)
        {
            stringForCheck = new string('0', (p - stringForCheck.Length) + 1) + stringForCheck;
        }
        string resultString = stringForCheck.Substring(0, stringForCheck.Length - (p + 1)) + v + stringForCheck.Substring(stringForCheck.Length - p, p);
        Console.WriteLine("Input: {0}",Convert.ToInt32(stringForCheck, 2));
        Console.WriteLine("Output: {0}", Convert.ToInt32(resultString, 2));
        Console.ReadLine();
    }
}
