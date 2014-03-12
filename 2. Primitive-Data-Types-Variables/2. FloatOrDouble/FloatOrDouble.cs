using System;

class FloatOrDouble
{
    static void Main()
    {
        //Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? 
        Console.Title = "ConsoleApp - Choose Float or Double";
        double firstDoubleVariable = 34.567839023;
        float firstFloatVariable = 12.345f;
        double secondDoubleVariable = 8923.1234857;
        float secondFloatVarriable = 3456.091f;
        Console.WriteLine("Lets check if there is precision lost:\n34,567839023 = {0}\n12,345 = {1}\n8923,1234857 = {2}\n3456,091 = {3}", firstDoubleVariable, firstFloatVariable, secondDoubleVariable, secondFloatVarriable);
    }
}

