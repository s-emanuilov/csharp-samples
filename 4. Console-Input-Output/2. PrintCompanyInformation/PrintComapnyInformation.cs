using System;

class PrintComapnyInformation
{
    static void Main()
    {
        // A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.
        Console.Title = "ConsoleApp - Print company information";
        Console.WriteLine("Company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company address");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Phone number:");
        string phoneNum = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string faxNum = Console.ReadLine();
        Console.WriteLine("Web site:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        string firstName=Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Manager age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone:");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0}\r\nAdress: {1}\r\nTel.{2}\r\nFax: {3}\r\nWebsite: {4}\r\nManager: {5} {6} (age: {7}, tel: {8})",companyName, companyAddress,phoneNum,faxNum, webSite, firstName, lastName,age,managerPhone);
        Console.ReadLine();
    }
}

