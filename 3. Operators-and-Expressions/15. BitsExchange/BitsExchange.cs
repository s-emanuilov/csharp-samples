using System;

class BitsExchange
{
    static void Main()
    {
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 
        Console.Title = "ConsoleApp - Bits exchange";
        Console.WriteLine("Please enter your number: ");
        uint num = uint.Parse(Console.ReadLine());
        uint rightBits = (num >> 3) & 7;
        rightBits <<= 24;
        uint leftBits = (num >> 24) & 7;
        leftBits <<= 3;
        uint result = 0;
        uint mask1 = num >> 27;
        mask1 <<= 27;
        result = mask1 | rightBits;             
        uint mask2 = num << 8;
        mask2 >>= 8;
        result = result | mask2;
        result >>= 6;
        result = (result <<= 6) | leftBits;
        uint mask3=num << 29;
        mask3 >>= 29;
        result |= mask3;
        Console.WriteLine("Input: {0} \nbitwise: {1}\n", num, Convert.ToString(num, 2).PadLeft(32, '0'));
        Console.WriteLine("Output: {0} \nbitwise: {1}", result, Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.ReadLine();
    }
}

