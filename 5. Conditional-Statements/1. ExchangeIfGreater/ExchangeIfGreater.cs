using System;

class ExchangeIfGreater
{
    static void Main()
    {
        //Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. 
        Console.Title = "ConsoleApp - Exchange if greater";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter the first number:");
        double firstNum = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        double secondNum = Double.Parse(Console.ReadLine());
        Console.WriteLine("Input: a = {0}, b = {1}", firstNum, secondNum);
        if (firstNum > secondNum)
        {
            firstNum += secondNum;
            secondNum = firstNum - secondNum;
            firstNum -= secondNum;
            Console.WriteLine("Output: {0} {1}", firstNum, secondNum);
        }
        else
        {
            Console.WriteLine("Output: {0} {1}", firstNum, secondNum);
        }
        Console.ReadLine();
    }
}
