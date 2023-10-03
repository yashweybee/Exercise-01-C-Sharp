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
            char c1 = 'A';

            //Console.WriteLine((char)(64));



            for (int i = 1; i <= 5; i++)
            {
                c1 = 'A';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(c1);
                    c1 = (char)(c1 + 1);
                }
                Console.WriteLine();
            }

            for(int i = 1; i <= 5; i++)
            {
                //c2 = '';
                c1 = (char)(c1 - 1);
                Console.Write(c1);

            }
            
            Console.ReadLine();
        }
    }
}
