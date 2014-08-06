using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Kreditopolu4ateli___krediti
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter SW;
            StreamWriter SW2;
            int cnt = 0;
            int cnt2 = 1;
            int nomer = 1;

            SW = File.CreateText("e:\\creditPerson.txt");
            FileInfo f = new FileInfo("e:\\creditPerson.txt");
            SW2 = File.CreateText("e:\\credit.txt");
            while (cnt < cnt2)
            {
                //first file creditPerson
                SW.WriteLine("Кредитополучател " + nomer);
                Console.Write("Трите имена: ");
                string names = Console.ReadLine();
                SW.WriteLine("Трите имена на кредитополучателя: " + names);
                Console.Write("Адрес: ");
                string adress = Console.ReadLine();
                SW.WriteLine("Адрес: " + adress);
                Console.Write("Месторабота: ");
                string mestorabota = Console.ReadLine();
                SW.WriteLine("Месторабота: " + mestorabota);
                Console.Write("Доходи на кредитополучателя: ");
                double dohodPoluchatel = double.Parse(Console.ReadLine());
                SW.WriteLine("Доходи на кредитополучателя: " + dohodPoluchatel + "лв.");
                Console.Write("Обезщетение от поръчител: ");
                double obezshtetenie = double.Parse(Console.ReadLine());
                SW.WriteLine("Обезщетение: " + obezshtetenie + "лв.");
                SW.WriteLine();

                //second file credit.txt
                SW2.WriteLine("Кредит " + nomer);
                Console.Write("Месечна лихва(%): ");
                double lihva = double.Parse(Console.ReadLine());
                SW2.WriteLine("Месечна лихва(%): " + lihva + "%");

                Console.Write("Срок на кредита(в години): ");
                double srok = double.Parse(Console.ReadLine());
                SW2.WriteLine("Срок на кредита(в години): " + srok);
                Console.Write("Искана сума: ");
                double pari = double.Parse(Console.ReadLine());
                SW2.WriteLine("Искана сума: " + pari);
                SW2.WriteLine("Стойност за погасяване: " + (pari * (1 + (srok * lihva/100))));
                SW2.WriteLine();
                nomer++;
                
                //check if u are continue or not
                Console.WriteLine("Въведете 0, за да продължите или 1 за край");
                cnt = int.Parse(Console.ReadLine());
                //if true close tha files credit.txt & creditPerson.txt
                if (cnt == 1)
                {
                    SW.Close();
                    SW2.Close();
                }
            }
        }
    }
}
