using System;
using System.Collections.Generic;

namespace Vonat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            feladat3();
        }

        static void feladat1()
        {
            Dictionary<string, int> kesesek = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine()); // 12

            for (int i = 0; i < n; i++) 
            {
                string[] sor = Console.ReadLine().Split(' ');
                string allomas = sor[0];
                int keses = int.Parse(sor[1]);

                if(!kesesek.ContainsKey(allomas))
                {
                    kesesek.Add(allomas,n);
                }
                else if (kesesek[allomas] < keses) 
                {
                    kesesek.Remove(allomas);
                    kesesek.Add(allomas,keses);
                }
            }
        }
    }
}
