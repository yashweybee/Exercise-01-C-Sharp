using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int starter = 1;
            int n = 5;
            char ch = 'A';
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= (starter / 2); j++)
                {
                    Console.Write(ch++);
                }
                ch--;
                ch--;

                for (int k = 0; k < (starter / 2); k++)
                {
                    Console.Write(ch--);
                }
                Console.WriteLine();
                ch = 'A';
                starter = starter + 2;
            }
            Console.ReadLine();
        }
    }
}
