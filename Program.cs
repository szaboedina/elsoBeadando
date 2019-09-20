using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static int[] szamok = new int[10];
        static void Elso()
        {   
            Console.WriteLine("Kérem adjon meg 10 egész számot");
            int bekert;
            for (int i = 0; i < szamok.Length; i++)
            {
                bekert = Convert.ToInt32(Console.ReadLine());
                szamok[i] = bekert;
            }
        }

        static void Main(string[] args)
        {
            Elso();
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i]+"   ");

            }
            Console.ReadKey();
        }
    }
}
