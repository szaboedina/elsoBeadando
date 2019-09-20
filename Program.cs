using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static List<int> szamok = new List<int>();
        static void Beker()
        {
            Console.WriteLine("Kérem adjon meg hány számot szeretne felvenni:");
            int hossz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a számokat:");
            int bekert;
            for (int i = 0; i < hossz; i++)
            {
                bekert = Convert.ToInt32(Console.ReadLine());
                szamok.Add(bekert);
            }
        }


        static void Main(string[] args)
        {
            try
            {

                Beker();
                Console.WriteLine("A megadott számok: ");
                for (int i = 0; i < szamok.Count; i++)
                {
                    Console.Write(szamok[i] + "   ");
                }
                Console.WriteLine();

                int max = szamok[0];
                for (int i = 1; i < szamok.Count; i++)
                {
                    if (max < szamok[i])
                    {
                        max = szamok[i];
                    }
                }
                Console.WriteLine("A legnagyobb szám : " + max);
                int min = szamok[0];
                for (int i = 0; i < szamok.Count; i++)
                {
                    if (szamok[i] < min)
                    {
                        min = szamok[i];
                    }
                }
                Console.WriteLine("A legkisebb szám: " + min);





            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba történt");
            }

            Console.ReadKey();
        }
    }
}
