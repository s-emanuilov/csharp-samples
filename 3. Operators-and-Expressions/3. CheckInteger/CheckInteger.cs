using System;

class CheckInteger
{
    static void Main()
    {
        //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time       
        Console.Title = "ConsoleApp - Check Integer";
        Console.WriteLine("Please enter a number: ");
        int intForCheck = int.Parse(Console.ReadLine());
        if ((intForCheck % 5 == 0) && (intForCheck % 7 == 0))
        {
            Console.WriteLine("The number CAN be devided by 5 or 7 without remainder");
        }
        else
        {
            Console.WriteLine("The number can NOT be devided by 5 or 7 without remainder");
        }
        Console.ReadLine();
    }
}
