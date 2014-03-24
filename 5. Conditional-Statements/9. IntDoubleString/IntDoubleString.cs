using System;

class IntDoubleString
{
    static void Main()
    {
        //Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 
        Console.Title = "ConsoleApp - Play with Int, Double and String";
        Console.WriteLine("Please choose a type:\n\r1 --> int\n\r2 --> double\n\r3 --> string");
        string choise = Console.ReadLine();
        switch (choise)
        {
            case "1":
                Console.WriteLine("Please enter int:");
                int intVar = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}",intVar+1 );
                break;
            case "2":
                Console.WriteLine("Important! You have to use the right decimal separator for your system!");
                Console.WriteLine("Please enter a double:");
                double doubleVar = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", doubleVar+1);
                break;
            case "3":
                Console.WriteLine("Please enter a string:");
                string stringVar = Console.ReadLine();
                Console.WriteLine("Result: {0}*",stringVar);
                break;
            default:
                Console.WriteLine("Wrong input data!");
                break;
        }
        Console.ReadLine();
    }
}

