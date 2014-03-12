using System;

    class StringsAndObjects
    {
        static void Main()
        {
            //Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). 
            Console.Title = "ConsoleApp - Strings and Objects";
            string firstStringVar="Hello";
            string secondStringVar = "Word!";
            object objectVar = firstStringVar + " " + secondStringVar;
            string finalString = (string)objectVar;
            Console.WriteLine(finalString);
        }
    }

