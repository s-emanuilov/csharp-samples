using System;

    class LongestWord
    {
        static void Main()
        {
            //Write a program to find the longest word in a text. 
            Console.Title = "ConsoleApp - Find the longest word in a text";
            Console.WriteLine("Please enter your text:");
            string text = Console.ReadLine();
            string[] splitedText = text.Split(' ');
            string longestWord = splitedText[0];
            for (int i = 0; i < splitedText.Length; i++)
            {
                if (splitedText[i].Length > longestWord.Length)
                {
                    longestWord = splitedText[i];   
                }
            }
            Console.WriteLine(longestWord);
            Console.ReadLine();
        }
    }

