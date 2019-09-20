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
        static void Beker()
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
            Beker();
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i]+"   ");
            }
            Console.WriteLine();

            int max = szamok[0];
            for (int i = 1; i < szamok.Length; i++)
            {
                if (max<szamok[i])
                {
                    max = szamok[i];
                }
            }
            Console.WriteLine("A legnagyobb szám : "+max);






            Console.ReadKey();
        }
    }
}
