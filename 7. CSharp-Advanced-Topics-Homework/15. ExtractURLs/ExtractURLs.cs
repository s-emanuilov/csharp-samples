using System;

class ExtractURLs
{
    static void Main()
    {
        //Write a program that extracts and prints all URLs from given text. 
        Console.Title = "ConsoleApp - Extract URLs from text";
        string text = "The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.";
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 7)
            {
                if (words[i].Substring(0, 4) == "www." || words[i].Substring(0, 7) == "http://")
                {
                    if (words[i].EndsWith("."))
                    {
                        Console.WriteLine(words[i].Substring(0,words[i].Length-1));
                    }
                    else
                    {
                        Console.WriteLine(words[i]);
                    }
                }
            }

        }
        Console.ReadLine();
    }
}

