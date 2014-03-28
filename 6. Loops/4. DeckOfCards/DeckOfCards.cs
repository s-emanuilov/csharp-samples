using System;

class DeckOfCards
{
    static void Main()
    {
        char[] suits = new char[4] { '\u2663', '\u2666', '\u2665', '\u2660' };
        string[] faces = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "K", "A", "J", "Q" };
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("{0}{1} ",faces[i], suits[j]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

