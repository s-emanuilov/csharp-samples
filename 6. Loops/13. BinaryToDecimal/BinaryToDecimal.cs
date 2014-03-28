using System;

class BinaryToDecimal
{
    static void Main()
    {
        //Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 
        Console.Title = "ConsoleApp - Binary to decimal";
        Console.WriteLine("Please enter a binary number:");
        string binary = Console.ReadLine();
        long power = 1;
        int bit = 0;
        long result = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            for (int j = 0; j < (binary.Length - 1) - i; j++)
            {
                power *= 2;
            }
            if (binary[i] == '1')
            {
                bit = 1;
            }
            else
            {
                bit = 0;
            }
            result += bit * power;
            power = 1;
        }
        Console.WriteLine("Decimal: {0}", result);
        Console.ReadLine();
    }
}

