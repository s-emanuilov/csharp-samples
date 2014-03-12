using System;

    class BankAccountData
    {
        static void Main()
        {
            //A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
            Console.Title = "ConsoleApp - BankAccountData";
            string firstName = "Georgi";
            string middleName = "Ivanov";
            string lastName = "Liubomirov";
            decimal balance = 120.12m;
            string iban = "BG40UNCR90221511298510";
            ulong firstCreditCard = 4001459823845671;
            ulong secondCreditCard = 4002879278627612;
            ulong thirdCreditCard = 4003829283278234;
            Console.WriteLine("Name of Customer: {0} {1} {2} \nBalance: {3} BGN\nIBAN: {4}\nCredit Card 1: {5}\nCredit Card 2: {6}\nCredit Card 3: {7}", firstName, middleName, lastName, balance, iban, firstCreditCard, secondCreditCard, thirdCreditCard);

        }
    }

