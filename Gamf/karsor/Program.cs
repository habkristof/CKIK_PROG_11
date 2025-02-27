using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace karsor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Beolvas();
            tavolsagok(s);
        }

        static void tavolsagok(string s)
        {
            int x =0;
            int y = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if () { 
                }
            }
        }

        static string Beolvas()
        {
            StreamReader reader = new StreamReader("karsor.txt");
            string s = reader.ReadLine();
            reader.Close();
            return s;
        }
    }
}
