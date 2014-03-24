using System;

class DigitAsWord
{
    static void Main()
    {
        //Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Print “not a digit” in case of invalid inut. Use a switch statement. 
        Console.Title = "ConsoleApp - Digit as word";
        Console.WriteLine("Please enter a digit [0...9]");
        string input = Console.ReadLine();
        switch (input)
        {
            case "0":
                Console.WriteLine(input + "= zero");
                break;
            case "1":
                Console.WriteLine(input + "= one");
                break;
            case "2":
                Console.WriteLine(input + "= two");
                break;
            case "3":
                Console.WriteLine(input + "= three");
                break;
            case "4":
                Console.WriteLine(input + "= four");
                break;
            case "5":
                Console.WriteLine(input + "= five");
                break;
            case "6":
                Console.WriteLine(input + "= six");
                break;
            case "7":
                Console.WriteLine(input + "= seven");
                break;
            case "8":
                Console.WriteLine(input + "= eight");
                break;
            case "9":
                Console.WriteLine(input + "= nine");
                break;
            default:
                Console.WriteLine("Not a digit");
                break;
        }
        Console.ReadLine();
    }
}

