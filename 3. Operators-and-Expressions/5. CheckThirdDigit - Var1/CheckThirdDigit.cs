using System;

class CheckThirdDigit
{
    static void Main()
    {
        //Write an expression that checks for given integer if its third digit from right-to-left is 7. 
        Console.Title = "ConsoleApp - Check if third digit is 7";
        Console.WriteLine("Please enter a number:");
        int intForCheck = int.Parse(Console.ReadLine());
        if ((intForCheck / 100) % 10 == 7)
        {
            Console.WriteLine("The third digit is 7!");
        }
        else
        {
            Console.WriteLine("The third digit is different from 7!");

        }
        Console.ReadLine();
    }
}

