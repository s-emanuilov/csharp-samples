using System;

    class DeclaringVariables
    {
        static void Main()
        {
            //Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. 
            Console.Title = "ConsoleApp - Declaring Variables";
            ushort ushortVariable=52130;
            sbyte sbyteVariable = -115;
            int intVariable=4825932;
            byte byteVariable=97;
            short shortVariable = -10000;
            Console.WriteLine("First number: {0}\nSecond number: {1}\nThird number: {2}\nFourth number: {3}\nFifth number: {4}",ushortVariable, sbyteVariable, intVariable, byteVariable, shortVariable );
        }
    }

