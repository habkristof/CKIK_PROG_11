using System;
using System.Collections.Generic;
using System.IO;


namespace fajlok
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            List<int> primek = new List<int>();
            Beolvas(nevek, primek);
            Beolvas2(nevek, primek);
            Hozzafuzz(nevek, primek);
            Kiir(nevek, primek);
        }

        static void Hozzafuzz(List<string> nevek, List<int> primek)
        {
            StreamWriter writer = new StreamWriter("valtozo.txt");
            for (int i = 0; i < nevek.Count; i++)
            {
                writer.WriteLine(nevek[i] + " " + primek[i]);
            }
        }

        static void Beolvas2(List<string> nevek, List<int> primek)
        {
            StreamReader reader = new StreamReader("primek.txt");
            string sor = reader.ReadLine();
            while(sor != null)
            {
                string[] adatok = sor.Split(' ');
                nevek.Add(adatok[0]);
                primek.Add(int.Parse(adatok[1]));
                sor = reader.ReadLine();
            }
            reader.Close();
        }

        static void Kiir(List<string> nevek, List<int> primek)
        {
            StreamWriter writer = new StreamWriter("kimenet.txt");
            for (int i = 0; i < nevek.Count; i++)
            {
                writer.WriteLine(nevek[i] + " : " + primek[i]);
            }
            Console.WriteLine("Megtörtént a kiírás akiment.txt-be");
            writer.Close();
        }

        static void Beolvas(List<string> nevek, List<int> primek)
        {
            string[] sorok = File.ReadAllLines("../../primek.txt");
            foreach (string sor in sorok )
            {
                string[] adatok = sor.Split();
                nevek.Add(adatok[0]);
                primek.Add(int.Parse(adatok[1]));
            }

        }
    }
}
    
