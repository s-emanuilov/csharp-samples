using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

// Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.

struct Rocks
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

class FallingRocks
{
    static void printRock(int x, int y, char c, ConsoleColor color = ConsoleColor.Red)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void printStringOnPosition(int x, int y, string s, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(s);
    }

    static void Main()
    {
        Console.Title = "FallingRocks";
        int speed = 0;
        int scores = 0;
        int playfield = 60;
        int livesCount = 3;
        char[] charArray = new char[11] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth = 70;
        Rocks dwarf = new Rocks();
        dwarf.x = playfield / 2;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = '0';
        dwarf.color = ConsoleColor.White;
        Random randGen = new Random();
        List<Rocks> rocks = new List<Rocks>();

        while (true)
        {
            speed += 5;
            scores++;
            //check when max speed is obtained
            if (speed > 445)
            {
                speed = 445;
            }

            bool collision = false;

            {
                int chance = randGen.Next(0, 100);

                //rock with 3 chars
                if (chance < 30)
                {
                    Rocks newRock = new Rocks();
                    newRock.x = randGen.Next(0, playfield - 2);
                    newRock.y = 0;
                    newRock.c = charArray[randGen.Next(0, 11)];
                    newRock.color = ConsoleColor.Yellow;
                    rocks.Add(newRock);

                    Rocks newRockDouble = new Rocks();
                    newRockDouble.x = newRock.x + 1;
                    newRockDouble.y = 0;
                    newRockDouble.c = charArray[randGen.Next(0, 11)];
                    newRockDouble.color = ConsoleColor.Red;
                    rocks.Add(newRockDouble);

                    Rocks newRockTriple = new Rocks();
                    newRockTriple.x = newRockDouble.x + 1;
                    newRockTriple.y = 0;
                    newRockTriple.c = charArray[randGen.Next(0, 11)];
                    newRockTriple.color = ConsoleColor.Green;
                    rocks.Add(newRockTriple);
                }
                //rock with 2 chars
                else if (chance > 70)
                {
                    Rocks newRock = new Rocks();
                    newRock.x = randGen.Next(0, playfield);
                    newRock.y = 0;
                    newRock.c = charArray[randGen.Next(0, 11)];
                    newRock.color = ConsoleColor.Magenta;
                    rocks.Add(newRock);

                    Rocks newRockDouble = new Rocks();
                    newRockDouble.x = newRock.x + 1;
                    newRockDouble.y = 0;
                    newRockDouble.c = charArray[randGen.Next(0, 11)];
                    newRockDouble.color = ConsoleColor.Gray;
                    rocks.Add(newRockDouble);
                }
                else
                {
                    Rocks newRock = new Rocks();
                    newRock.x = randGen.Next(0, playfield);
                    newRock.y = 0;
                    newRock.c = charArray[randGen.Next(0, 11)];
                    newRock.color = ConsoleColor.Green;
                    rocks.Add(newRock);
                }

            }

            //check for user action
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 2 >= 0)
                    {
                        dwarf.x--;
                    }

                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 2 < playfield)
                    {
                        dwarf.x++;
                    }
                }
            }

            //Moving in other <List>
            List<Rocks> newRocks = new List<Rocks>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rocks oldRock = rocks[i];
                Rocks newRock = new Rocks();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.color = oldRock.color;
                newRock.c = oldRock.c;

                //Check for collision
                if ((newRock.y == dwarf.y) && (newRock.x == dwarf.x || newRock.x == dwarf.x - 1 || newRock.x == dwarf.x + 1))
                {
                    livesCount--;
                    rocks.Clear();
                    collision = true;
                    if (livesCount <= 0)
                    {
                        printStringOnPosition(playfield, 5, "GAME OVER", ConsoleColor.Red);
                        Console.ReadLine();
                        return;
                    }
                }
                //Rocks disapear when end of console is reached
                if (newRock.y < Console.WindowHeight)
                {
                    newRocks.Add(newRock);
                }

            }
            rocks = newRocks;

            Console.Clear();
            //Action when rock hit the dwarf
            if (collision)
            {
                printRock(dwarf.x - 1, dwarf.y - 1, '\\', ConsoleColor.Red);
                printRock(dwarf.x - 1, dwarf.y, '-', ConsoleColor.Red);
                printRock(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
                printRock(dwarf.x + 1, dwarf.y, '-', ConsoleColor.Red);
                printRock(dwarf.x + 1, dwarf.y - 1, '/', ConsoleColor.Red);
            }
            else
            {
                printRock(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
                printRock(dwarf.x - 1, dwarf.y, '(', dwarf.color);
                printRock(dwarf.x + 1, dwarf.y, ')', dwarf.color);

            }
            foreach (Rocks rock in rocks)
            {
                printRock(rock.x, rock.y, rock.c, rock.color);
                //  printRock(Math.Max(rock.x,playfield-rock.x), rock.y, rock.c, rock.color);
            }
            printStringOnPosition(playfield, 0, "Lives:" + livesCount);
            printStringOnPosition(playfield, 2, "Speed:" + speed);
            printStringOnPosition(playfield, 3, "Scores:" + scores);
            //game speed
            Thread.Sleep(500 - speed);
        }
    }
}

