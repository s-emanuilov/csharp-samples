using System;

class CalculateWeightMoon
{
    static void Main()
    {
        //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 
        Console.Title = "ConsoleApp - Calculate your weight on the Moon";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter your weight in kg:");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("If your weight here is {0}kg., then on the Moon you will be {1}kg.", weight, weight * 0.17);
        Console.ReadLine();
    }
}

