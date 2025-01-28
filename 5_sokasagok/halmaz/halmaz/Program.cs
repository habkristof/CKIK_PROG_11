using System;
using System.Collections.Generic;

namespace Halmazos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> halmaz1 = new HashSet<string> { "Bence", "Réka", "Máté", "Pisti", "Johanna", "Kata" };
            HashSet<string> halmaz2 = new HashSet<string> { "Máté", "Zalán", "Csaba", "Kata", "Bence" };

            Kiir("1.Verseny:", halmaz1);
            Kiir("2.Verseny:", halmaz2);
            Kiir("Mindkettő:", Metszete(halmaz1, halmaz2));
            Kiir("Legalább egyik verseny:", Unio(halmaz1, halmaz2));
            Kiir("CSak az 1. versenyen indulók: ", Kulonbseg(halmaz1, halmaz2));

            HashSet<string> bitfarago = new HashSet<string> { "Máté", "Csaba", "Zalán" };
            Console.WriteLine("Rész halmaz(bitfarago), halmaz1?, " + ReszhalmazE(bitfarago, halmaz1)); // false
            Console.WriteLine("Rész halmaz(bitfarago), halmaz2?, " + ReszhalmazE(bitfarago, halmaz2)); // true
            Console.ReadKey();

            Console.WriteLine("VanKozos(bitfarago), halmaz1");
        }

        static bool ReszhalmazE(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            bool reszhalmaza =true;
            foreach (string elem in halmaz1)
            {
                if (!halmaz2.Contains(elem))
                {
                    reszhalmaza = false;
                }
            }
            return reszhalmaza;
        }

        static HashSet<string> Kulonbseg(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            HashSet<string> kulonbseg = new HashSet<string>();
            foreach (string elem in halmaz1 )
            {
                if (!halmaz1.Contains(elem))
                {
                    kulonbseg.Add(elem);
                }
                 
            }
            return kulonbseg;
        }

        static HashSet<string> Unio(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            HashSet<string> unio = new HashSet<string>();
            foreach (string egyes in halmaz1)
            {
                unio.Add(egyes);

            }
            foreach (string kettes in halmaz2)
            {
                unio.Add(kettes);
            }
            return unio;
        }

        static HashSet<string> Metszete(HashSet<string> halmaz1, HashSet<string> halmaz2)
        {
            HashSet<string> metszete = new HashSet<string>();
            foreach (string elem in halmaz1)
            {
                if (halmaz2.Contains(elem))
                {
                    metszete.Add(elem);
                }
            }
            return metszete;
        }

        static void Kiir<T>(string szoveg, HashSet<T> halmaz)
        {
            Console.Write(szoveg);
            Console.WriteLine(" ");
            int db = 0;
            foreach (T elem in halmaz)
            {
                db++;
                if (db < halmaz.Count)
                {
                    Console.Write(elem + ", ");
                }
                else
                {
                    Console.Write(elem);
                }
            }
            Console.WriteLine(" ");
        }
    }
}    

