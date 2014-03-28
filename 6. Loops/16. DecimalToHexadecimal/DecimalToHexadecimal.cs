using System;

    class DecimalToHexadecimal
    {
        static void Main()
        {
            //Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 
            Console.Title = "ConsoleApp - Convert an integer to hexadecimal format";
            Console.WriteLine("Please enter a decimal number:");
            long num = long.Parse(Console.ReadLine());
            long division = num;
            string hex = "";
            string binary = "";
            for (int i = 0; i < 64; i++)
            {
                if (division % 2 == 0)
                {
                    binary = "0" + binary;
                    division /= 2;
                }
                else
                {
                    binary = "1" + binary;
                    division /= 2;
                }
            }
            for (int i = 0; i < 64; i+=4)
            {
                switch (Convert.ToInt32(binary.Substring(i,4),2))
                {
                    case 0:
                        break;
                    case 1:
                        hex += "1";
                        break;
                    case 2:
                        hex += "2";
                        break;
                    case 3:
                        hex += "3";
                        break;
                    case 4:
                        hex += "4";
                        break;
                    case 5:
                        hex += "5";
                        break;
                    case 6:
                        hex += "6";
                        break;
                    case 7:
                        hex += "7";
                        break;
                    case 8:
                        hex += "8";
                        break;
                    case 9:
                        hex += "9";
                        break;
                    case 10:
                        hex += "A";
                        break;
                    case 11:
                        hex += "B";
                        break;
                    case 12:
                        hex += "C";
                        break;
                    case 13:
                        hex += "D";
                        break;
                    case 14:
                        hex += "E";
                        break;
                    case 15:
                        hex += "F";
                        break;
                    default:
                     break;
                }
            }
            Console.WriteLine("Hex output: {0}", hex);
            Console.ReadLine();
        }
    }

