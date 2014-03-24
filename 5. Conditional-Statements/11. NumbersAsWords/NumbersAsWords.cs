using System;

class NumbersAsWords
{
    static void Main()
    {
        //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 
        Console.Title = "ConsoleApp - Numbers as words";
        Console.WriteLine("Please enter your number [0..999]:");
        int num = int.Parse(Console.ReadLine());
        int lastDigit = num / 100;
        int middleDigit = (num / 10) % 10;
        int firstDigit = num % 10;
        string numWithWords = "";
        string[] digits = new string[10] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        if (lastDigit != 0)
        {
            if (middleDigit == 0 && firstDigit == 0)
            {
                numWithWords = digits[lastDigit] + " hundred";
            }
            else
            {
                numWithWords = digits[lastDigit] + " hundred and ";
            }

        }

        switch (middleDigit)
        {
            case 0:
                if (firstDigit == 0 && lastDigit == 0)
                {
                    numWithWords = "zero";
                }
                numWithWords += digits[firstDigit];
                break;
            case 1:
                switch (firstDigit)
                {
                    case 0: numWithWords += "ten";
                        break;
                    case 1: numWithWords += "eleven";
                        break;
                    case 2: numWithWords += "twelve";
                        break;
                    case 3: numWithWords += digits[firstDigit] + "teen";
                        break;
                    case 4: numWithWords += digits[firstDigit] + "teen";
                        break;
                    case 5: numWithWords += "fifteen";
                        break;
                    case 6: numWithWords += digits[firstDigit] + "teen";
                        break;
                    case 7: numWithWords += digits[firstDigit] + "teen";
                        break;
                    case 8: numWithWords += digits[firstDigit] + "teen";
                        break;
                    case 9: numWithWords += digits[firstDigit] + "teen";
                        break;
                    default: numWithWords += "";
                        break;
                }
                break;
            case 2:
                switch (firstDigit)
                {
                    case 0: numWithWords += "twenty";
                        break;
                    default: numWithWords += "twenty " + digits[firstDigit];
                        break;
                }
                break;
            case 3:
                switch (firstDigit)
                {
                    case 0: numWithWords += "thirty";
                        break;
                    default: numWithWords += "twenty " + digits[firstDigit];
                        break;
                }
                break;
            case 4:
                switch (firstDigit)
                {
                    case 0: numWithWords += "fourty";
                        break;
                    default: numWithWords += "fourty " + digits[firstDigit];
                        break;
                }
                break;
            case 5:
                switch (firstDigit)
                {
                    case 0: numWithWords += "fifty";
                        break;
                    default: numWithWords += "fourty " + digits[firstDigit];
                        break;
                }
                break;
            case 6:
                switch (firstDigit)
                {
                    case 0: numWithWords += "sixty";
                        break;
                    default: numWithWords += "fourty " + digits[firstDigit];
                        break;
                }
                break;
            case 7:
                switch (firstDigit)
                {
                    case 0: numWithWords += "seventy";
                        break;
                    default: numWithWords += "seventy " + digits[firstDigit];
                        break;
                }
                break;
            case 8:
                switch (firstDigit)
                {
                    case 0: numWithWords += "eighty";
                        break;
                    default: numWithWords += "eighty " + digits[firstDigit];
                        break;
                }
                break;
            case 9:
                switch (firstDigit)
                {
                    case 0: numWithWords += "ninety";
                        break;
                    default: numWithWords += "ninety " + digits[firstDigit];
                        break;
                }
                break;
            default: numWithWords += "";
                break;
        }
        Console.WriteLine("Number: {0}, in words: {1}", num, numWithWords);
        Console.ReadLine();
    }
}
