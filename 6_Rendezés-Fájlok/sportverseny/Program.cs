using System;
using System.Collections.Generic;
using System.IO;

namespace Sportverseny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            List<string> orszagok = new List<string>();
            List<int> pontok = new List<int>();
            Beolvas(nevek, orszagok, pontok);
            Rendez(nevek, orszagok, pontok);
            Kiir(nevek, orszagok, pontok);
        }

        static void Kiir(List<string> nevek, List<string> orszagok, List<int> pontok)
        {
            StreamWriter sw = new StreamWriter("rendezett.txt");
            for (int i = 0; i < nevek.Count-1; i++)
            {
                int helyezes = 0;
                if (pontok[i] == pontok[i +1])
                {
                    sw.WriteLine($" {helyezes + " " }{nevek[i]} ({orszagok[i]}) - {pontok[i]}");
                }
                else
                {
                    sw.WriteLine($" {helyezes + " "}{nevek[i]} ({orszagok[i]}) - {pontok[i]}");
                }
                
            }
            sw.Close();
            Console.WriteLine("Fájlba írás megtörtént!");
        }

        static void Rendez(List<string> nevek, List<string> orszagok, List<int> pontok)
        {
            for (int i = 0; i < pontok.Count; i++)
            {
                for (int j = 0; j < pontok.Count - i - 1; j++)
                {
                    if (pontok[j] < pontok[j + 1] || pontok[j] == pontok[j + 1] && nevek[j].CompareTo(nevek[j + 1]) == 1)
                    {
                        Csere(pontok, j, j + 1);
                        Csere(nevek, j, j + 1);
                        Csere(orszagok, j, j + 1);
                    }
                }
            }
        }
        static void Csere<T>(List<T> pontok, int i, int j)
        {
            (pontok[i], pontok[j]) = (pontok[j], pontok[i]);
        }

        static void Beolvas(List<string> nevek, List<string> orszagok, List<int> pontok)
        {
            StreamReader sr = new StreamReader("eredmeny.csv");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(',');
                nevek.Add(sor[0]);
                orszagok.Add(sor[1]);
                pontok.Add(int.Parse(sor[2]));
            }
            sr.Close();
        }
    }
}