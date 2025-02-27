using System;
using System.Collections.Generic;

namespace Gyros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
        }

        static void Feladat3()
        {
            Console.WriteLine("\n3. feladat");
            List<List<int>> etterem = new List<List<int>>();
            Beolvas(etterem);
            Legnagyobb(etterem);
            
        }

        static void Legnagyobb(List<List<int>> etterem)
        {
            maxind = 0;
            foreach (int elem  in etterem)
            {
                if (true)
                {

                }
            }
        }

        static void Beolvas(List<List<int>> etterem)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' ');

                for (int j = 0; j < sor.Length; j++)
                {

                }
            }
        }

        static void Feladat2()
        {
            Console.WriteLine("\n2. feladat");
            List<string> varosszamok = new List<string> { "Budapest", "Cegléd", "Kecskemét", "Pécs", "Budapest", "Szolnok", "Budapest", "Debrecen", "Szolnok", "Budapest", "Budapest", "Cegléd","Szolnok"};

            Dictionary<string, int > hanyszor = new Dictionary<string, int>();
                foreach (string varos in varosszamok)
                {
                    if (varosszamok.ContainsKey(varos))
                    {
                        varosszamok[varos]++;
                    }
                    else
                    {
                        varosszamok[varos] = 1;
                    }

                }
        }

        

        static void Feladat1()
        {
            Console.WriteLine("1. feladat");
            HashSet<string> h1 = new HashSet<string> { "hagyma", "csípős", "sajt", "saláta", "uborka", "paradicsom" };
            HashSet<string> h2 = new HashSet<string> { "csípős", "paradicsom", "káposzta", "saláta", "hagyma", "paprika" };
            Console.WriteLine("a)");
            Mindketten(h1, h2);

            Console.WriteLine($"b)");
            HashSet<string> csakmate = new HashSet<string>(h1);
            csakmate.ExceptWith(h2);
            

            Console.ReadKey();
        }

        static void Mindketten(HashSet<string> h1, HashSet<string> h2)
        {
            HashSet<string> mindketten = new HashSet<string>();
            foreach (string elem in h2)
            {
                if (h2.Contains(elem))
                {
                    mindketten.Add(elem);
                }
            }
            
            
        }
  
    }
}
