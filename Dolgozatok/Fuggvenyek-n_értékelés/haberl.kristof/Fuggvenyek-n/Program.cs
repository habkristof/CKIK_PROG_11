using System;

namespace Fuggvenyek_n
{
    internal class Program
    {
        //2es feladat
        static void Kiir(int[] tömb,int elemszam)
        {
            for (int i = 0; i < elemszam; i++)
            {
                Console.Write(tömb[i] + " ");
            }
            Console.WriteLine();
        }

        // 1es feladat
        static double Terulet(double a)
        {
            return (Math.Sqrt(3) * a * a) / 4;
        }

        // 3as feladat

        static int Kivalogat( int[] x,  int db)
        {
            int[] l = new int[100];
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 4 == 0)
                {
                    l[db] = x[i];
                }
            }
        }

        //4  es feladat
         static bool VanOtos(int szam)
        {
            while (szam > 0)
            {
                if (szam % 10 == 5)
                {
                    return true;
                }
                szam /= 10;
            }
            return false;
        }

        //5 es feladat
        static int OtosSzamokSzama(int n)
        {
            int db = 0;
            for (int i = 0; i < n; i++)
            {
                if (VanOtos[i])
                {

                }
            }
        }
        static void Main(string[] args)
        {
            // F1
            Console.WriteLine("F1:");
            Console.WriteLine($"{Terulet(5):0.00}");
            Console.WriteLine($"{Terulet(2.6321):0.00}");

            // F2
            Console.WriteLine("\nF2:");
            Kiir(new int[] {5, 13, -2, 3}, 4);

            // F3
            Console.WriteLine("\nF3:");
            int[] x = { 1996, -48, 11614, 452, -818, 2024 };
            int db;
            int[] y = Kivalogat(x, db);
            Kiir(y, db);

            // F4
            Console.WriteLine("\nF4:");
            Console.WriteLine(VanOtos(9132546));
            Console.WriteLine(VanOtos(3052551));
            Console.WriteLine(VanOtos(138861));

            // F5
            Console.WriteLine("\nF5:");
            Console.WriteLine(OtosSzamokSzama(80));
            Console.WriteLine(OtosSzamokSzama(820));
        }
    }
}
