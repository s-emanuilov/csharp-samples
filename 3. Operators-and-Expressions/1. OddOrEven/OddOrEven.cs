using System;

class OddOrEven
{
    static void Main()
    {
        //Write an expression that checks if given integer is odd or even.
        Console.Title = "ConsoleApp - Odd or Even";
        Console.WriteLine("Please enter a number: ");
        int intForCheck = int.Parse(Console.ReadLine());
        if (intForCheck % 2 == 0)
        {
            Console.WriteLine("The number {0} is ЕVEN", intForCheck);
        }
        else
        {
            Console.WriteLine("The number {0} is ODD", intForCheck);
        }
        Console.ReadLine();
    }
}
