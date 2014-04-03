using System;

class CountingWordInText
{
    static void Main()
    {
        //Write a program that counts how many times a given word occurs in given text.
        //The first line in the input holds the word. The second line of the input holds the text.
        //The output should be a single integer number – the number of word occurrences. 
        //Matching should be case-insensitive. Note that not all matching substrings are words and 
        //should be counted. A word is a sequence of letters separated by punctuation or start / end of text. 
        Console.WriteLine("Please enter your word:");
        string word = Console.ReadLine().ToUpper();
        string text = "The Software University (SoftUni) trains software engineers, gives them a profession and a job. Visit us at http://softuni.bg. Enjoy the SoftUnification at SoftUni.BG. Contact us.Email: INFO@SOFTUNI.BG. Facebook: https://www.facebook.com/SoftwareUniversity. YouTube: http://www.youtube.com/SoftwareUniversity. Google+: https://plus.google.com/+SoftuniBg/. Twitter: https://twitter.com/softunibg. GitHub: https://github.com/softuni";

        string[] splitedText = text.Split(' ');
        int buffer = 0;
        for (int i = 0; i < splitedText.Length; i++)
        {
            splitedText[i] = splitedText[i].ToUpper();
            if (splitedText[i] == word + "." + word || splitedText[i] == word + "|" + word || splitedText[i] == word + "," + word)
            {
                buffer++;
            }

            if (splitedText[i].EndsWith(".") || splitedText[i].EndsWith(",") || splitedText[i].EndsWith("!") || splitedText[i].EndsWith("?") || splitedText[i].EndsWith(":") || splitedText[i].EndsWith(";") || splitedText[i].EndsWith("\"") || splitedText[i].EndsWith("”"))
            {
                splitedText[i] = splitedText[i].Substring(0, splitedText[i].Length - 1);
            }
            if (splitedText[i].StartsWith("“") || splitedText[i].StartsWith("\""))
            {
                splitedText[i] = splitedText[i].Substring(1, splitedText[i].Length - 1);
            }
            if (splitedText[i].Contains(word))
            {
                if (splitedText[i].IndexOf(word) != 0)
                {
                    if (splitedText[i][splitedText[i].IndexOf(word) - 1] == '@' || splitedText[i][splitedText[i].IndexOf(word) - 1] == '(' || splitedText[i][splitedText[i].IndexOf(word) - 1] == '/' || splitedText[i][splitedText[i].IndexOf(word) - 1] == '.')
                    {
                        splitedText[i] = splitedText[i].Substring(splitedText[i].IndexOf(word));
                    }
                }
                if (splitedText[i].Length > splitedText[i].IndexOf(word) + word.Length)
                {
                    if (splitedText[i][splitedText[i].IndexOf(word) + word.Length] == '.' || splitedText[i][splitedText[i].IndexOf(word) + word.Length] == ')')
                    {
                        splitedText[i] = splitedText[i].Substring(splitedText[i].IndexOf(word), word.Length);
                    }
                }
            }
            splitedText[i].Trim();
        }
        int counter = 0;
        for (int i = 0; i < splitedText.Length; i++)
        {
            if (splitedText[i] == word)
            {
                counter++;
            }
        }
        Console.WriteLine(counter + buffer);
        Console.ReadLine();
    }
}

