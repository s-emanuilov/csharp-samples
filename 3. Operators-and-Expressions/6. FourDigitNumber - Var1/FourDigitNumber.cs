using System;

class FourDigitNumber
{
    static void Main()
    {
        // Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        //•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        //•	Prints on the console the number in reversed order: dcba (in our example 1102).
        //•	Puts the last digit in the first position: dabc (in our example 1201).
        //•	Exchanges the second and the third digits: acbd (in our example 2101).
        Console.Title = "ConsoleApp - Four digit number";
        Console.WriteLine("Please enter four digit number:");
        int num = int.Parse(Console.ReadLine());
        int[] numArray = new int[4] { num / 1000, (num / 100) % 10, (num / 10) % 10, num % 10 };
        int sum = 0;
        for (int i = 0; i < numArray.Length; i++)
        {
            sum += numArray[i];
        }
        Console.WriteLine("The sum of the digits is: {0}", sum);
        Console.WriteLine("The digits in reversed order: {0}", numArray[3].ToString() + numArray[2].ToString() + numArray[1].ToString() + numArray[0].ToString());
        Console.WriteLine("Lets put the last digit on the first place: {0}", numArray[3].ToString() + numArray[0].ToString() + numArray[1].ToString() + numArray[2].ToString());
        Console.WriteLine("Change position of second and third digits: {0}", numArray[0].ToString() + numArray[2].ToString() + numArray[1].ToString() + numArray[3].ToString());
        Console.ReadLine();
    }
}

