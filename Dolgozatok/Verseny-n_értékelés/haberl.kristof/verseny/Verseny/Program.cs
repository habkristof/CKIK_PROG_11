using System;


namespace Verseny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] h = new int[200, 30];
            Beolvasas(h, out int n, out int m);
            feladat2(h, n, m);
            feladat3(h, n, m);
            feladat4(h, n, m);
        }
        //Kiválogatás

        static void feladat4(int[,] h, int n, int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    while (j < m && !(h[i, j] > 0))
                    {
                        if (j < n)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            Console.WriteLine();
        }

        // Maximum kiválasztás
        static void feladat3(int[,] h, int n, int m)
        {
            int maxi;
            for (int i = 0; i < m; i++)
            {
                maxi = 0;
                for (int j = 0; j < n; j++)
                {
                    if (h[j,i] > maxi)
                    {
                        maxi = h[j, i];
                    }     
                }
                Console.WriteLine(maxi + " ");
            }
            Console.WriteLine();
        }
        // Összegzés
        static void feladat2(int[,] h, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                int össszpont = 0;
                for (int j = 0; j < m; j++)
                {
                    össszpont += h[i, j];
 
                }
                Console.WriteLine(össszpont + " ");
            }
            Console.WriteLine();
        }
        //Beolvasás
        static void Beolvasas(int[,] h, out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' ');

            n = Convert.ToInt32(sor[0]);
            m = Convert.ToInt32(sor[1]);

            for (int i = 0; i < n; i++)
            {
                sor = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    h[i, j] = Convert.ToInt32(sor[j]);
                }
            }
        }
    }
}
