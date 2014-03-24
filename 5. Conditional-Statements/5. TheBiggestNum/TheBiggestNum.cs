using System;

class TheBiggestNum
{
    static void Main()
    {
        //Write a program that finds the biggest of three numbers. 
        Console.Title = "ConsoleApp - Find the biggest number";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter a number \"a\":");
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"b\":");
        double b = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"c\":");
        double c = Double.Parse(Console.ReadLine());
        if (a>b)
        {
            if (a>c)
	        {
                Console.WriteLine("The bigest number is: {0}",a);
		 
	        }
            else
	        {
                Console.WriteLine("The bigest number is: {0}",c);
        	}
        }
        else
        {
            if (b>c)
            {
                Console.WriteLine("The bigest number is: {0}",b);
            }
            else
            {
                Console.WriteLine("The bigest number is: {0}",c);
            }
        }
        Console.ReadLine();
    }
}

