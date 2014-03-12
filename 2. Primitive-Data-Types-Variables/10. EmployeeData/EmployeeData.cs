using System;

    class EmployeeData
    {
        static void Main()
        {
            //A marketing company wants to keep record of its employees. Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. 
            Console.Title = "ConsoleApp - EmployeeData";
            string firstName = "Stoian";
            string lastName = "Ivanov";
            byte age = 27;
            char gender='m';
            long personalIDNumber = 8306112507;
            int uniqueEmployeeNumber = 27569999;
            Console.WriteLine("Name of the employee: {0} {1}\nAge: {2}\nGender (m=Male, f=Female): {3}\nPersonal ID Number: {4}\nUnique Employee Number: {5}\n ",firstName,lastName, age, gender, personalIDNumber, uniqueEmployeeNumber);
        }
    }

