using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace ido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch ora = new Stopwatch();
            Console.WriteLine("Gyakoriság:" + Stopwatch.Frequency + "Hz");

            const int n = 100;

            ora.Start();
            List<int> lista = Feltolt(n);
            ora.Stop();
            Console.WriteLine("Eltelt idő(lista):" + ora.ElapsedTicks);


            ora.Reset();
            ora.Start();
            int[] tomb = Feltolt2(n);
            ora.Stop();
            Console.WriteLine("Eltelt idő(tömb):" + ora.ElapsedTicks);


        }

        static int[] Feltolt2(int n)
        {
            int[] tomb = new int[n];
            for (int i = 0; i < n; i++)
            {
                tomb[i] = i + 1;
            }
            return tomb;
        }

        static List<int> Feltolt(int n)
        {
            List<int> eredmeny = new List<int>();
            for (int i = 0; i < n; i++)
            {
                eredmeny.Add(n + 1);
            }
            return eredmeny;
        }
    }
}
