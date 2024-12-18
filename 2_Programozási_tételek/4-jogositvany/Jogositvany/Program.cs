﻿using System;

namespace Jogositvany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Elnevezési konveciók:
            // PascalCase => C# (ReadLine)
            // camelCase => JS (addEventListener)
            // kebab-case => CSS (list-style-type)
            int n = Convert.ToInt32(Console.ReadLine());

            // Statikus tömbök: fordítási időben tudnunk kell a méretét!
            // EZ ÍGY NEM JÓ!!!
            // string[] nevek = new string[n];
            string[] nevek = new string[100];
            int[] korok = new int[100];
            bool[] jogsik = new bool[100]; // jogsik[i]: az i. adatnak van-e jogsija?

            // F1 - Beolvasás
            /*
             if (adatok[2] == "I") jogsik[i] = true;
             else jogsik[i] = false; 
            */
            // jogsik[i] = adatok[2] == "I" ? true : false; // ternary operator
            int i;
            for (i = 0; i < n; i++)
            {
                string sor = Console.ReadLine(); // "Daniel 30 I"
                string[] adatok = sor.Split(' '); // { "Daniel", "30", "I" }
                nevek[i] = adatok[0]; // { "Daniel", "Marta", ... }
                korok[i] = Convert.ToInt32(adatok[1]);
                jogsik[i] = adatok[2] == "I";
            }

            // F2 - Megszámolás
            // jogsik[i] == true
            int db = 0;
            for (i = 0; i < n; i++)
            {
                if (jogsik[i])
                {
                    db++;
                }
            }
            double szazalek = (double) db / n * 100;
            Console.WriteLine($"2. {szazalek}%");

            // F3 - Keresés
            i = 0;
            while (i < n && !(korok[i] > 30 && !jogsik[i]))
            {
                i++;
            }
            if (i < n)
            {
                Console.WriteLine($"3. {nevek[i]}");
            }
            else
            {
                Console.WriteLine($"3. Nincs ilyen ember.");
            }

            // F4 - Min-Max kiválasztás
            /*
            int maxe = korok[0];
            for (i = 1; i < n; i++)
            {
                if (korok[i] > maxe)
                {
                    maxe = korok[i];
                }
            }
            int mine = korok[0];
            for (i = 1; i < n; i++)
            {
                if (korok[i] < mine)
                {
                    mine = korok[i];
                }
            }
            Console.WriteLine($"3. {maxe - mine}");
            */
            int maxe = korok[0];
            int mine = korok[0];
            for (i = 1; i < n; i++)
            {
                if (korok[i] > maxe)
                {
                    maxe = korok[i];
                }
                if (korok[i] < mine)
                {
                    mine = korok[i];
                }
            }
            Console.WriteLine($"3. {maxe - mine}");

            // F5 - Megszámolás
            int legalabb20 = 0;
            int alattiak = 0;
            for (i = 0; i < n; i++)
            {
                if (korok[i] >= 20 && jogsik[i])
                {
                    legalabb20++;
                }
                else if (korok[i] < 20 && jogsik[i])
                {
                    alattiak++;
                }
            }
            if (legalabb20 > alattiak)
            {
                Console.WriteLine("5. Igaz."); // a legalább 20 évesek többen vannak
            }
            else // (legalabb20 <= alattiak
            {
                Console.WriteLine("5. Nem igaz."); // a legalább 20 évesek legfeljebb annyian vannak
            }

            // F6 - Keresés -> while (nem járjuk be az egész tömböt)
            i = 0;
            // nev = nevek[0] -> "Daniel"
            // nev[0] -> 'D'
            // nevek[0][0] -> 'D'
            while (i < n && !(nevek[i][0] == 'F'))
            {
                i++;
            }
            if (i < n)
            {
                Console.WriteLine($"6. {nevek[i]}");
            }
            else
            {
                Console.WriteLine($"6. Nincs F betűvel kezdődő név.");
            }

            // F7 - Összegzés
            int osszeg = 0;
            // utolsó (hátulról az 1.): n-1
            // utolsó előtti (hátulról a 2.): n-2
            // ...
            // hátulról a 10.: n-10
            for (i = n-10; i < n; i++)
            {
                osszeg += korok[i];
            }
            double atlag = (double) osszeg / 10;
            Console.WriteLine($"7. {atlag}");

            // MO2
            int osszeg2 = 0;
            for (i = n-1; i >= n-10; i--)
            {
                osszeg2 += korok[i];
            }
            double atlag2 = (double)osszeg2 / 10;
            Console.WriteLine($"7. {atlag2}");

            // MO2
            int osszeg3 = 0;
            for (i = 1; i <= 10; i++)
            {
                osszeg3 += korok[n-i]; // n-1, n-2, ..., n-10
            }
            double atlag3 = (double)osszeg3 / 10;
            Console.WriteLine($"7. {atlag3}");

            //Console.ReadKey();
        }
    }
}
