using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SandGlass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int some = n;
            for (int i = 0; i < 2*n; i+=2)
            {
                if (some<0)
                {
                    break;
                }
                Console.Write(new string('.', i / 2));
                Console.Write(new string('*', some));
                Console.Write(new string('.', i / 2));
                some-= 2;
                Console.WriteLine();
            }
            some = n;
            for (int j = 1 ;j <n*2; j += 2)
            {
                if ((n-j)/2<0)
                {
                    break;
                }
                if (j==1)
                {
                    continue;
                }
                Console.Write(new string('.', ((n-j) / 2)));
                Console.Write(new string('*', j));
                Console.Write(new string('.', ((n - j) / 2)));
                Console.WriteLine();
            }
        }
    }

