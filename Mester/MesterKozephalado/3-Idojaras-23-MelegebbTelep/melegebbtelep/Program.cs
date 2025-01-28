using System;


namespace melegebbtelep
{
    internal class Program
    {
        static int Keres18Nagyobb(int[,] h, int n, int m)
        {
            bool megvanE = false;
            int i = 0;
            int j = 0;
            while (i < n && !megvanE)
            {
                j = 0;
                while (j < m && !megvanE)
                {
                    megvanE = h[i, j] > 18;
                    j++;
                }
                i++;
            }
            Console.WriteLine($"{i} {j}");
            if (megvanE)
            {
                return h[i, j];
            }
            else
            {
                return -1;
            }
            
        }

        static void Beolvas(int[,] h, out int n, out int m)
        {
            string[] elsosor = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(elsosor[0]);
            m = Convert.ToInt32(elsosor[1]);
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    h[i, j] = Convert.ToInt32(sor[j]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] h = new int[1000, 1000];
            Beolvas(h, out int n, out int m);

            //Console.WriteLine(Keres18Nagyobb)(h, n, m);

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if(MelegebbE(h, m, i, j))
            //        {
            //            Console.WriteLine(i+1);
            //        }
            //        //Console.WriteLine($" {i} {j} {MelegebbE(h, m, i, j)}");
            //    }
            //}

            int i = MasnalMelegebb(h, n, m);
            Console.WriteLine(i);
        }

        static int MasnalMelegebb(int[,] h, int n, int m)
        {
            int i = 0;
            int j = 0;
            bool megvanE = false;
            while (i < n && !megvanE)
            {
                j = 0;
                while (j < n && !megvanE)
                {
                    megvanE = MelegebbE(h, m, i, j); 
                    j++;
                }
                i++;
            }
            if (megvanE)
            {
                return i;
            }
            else
            {
                 return -1;
            }
        }

        static bool MelegebbE(int[,] h, int m, int i, int j)
        {
            int k = 0;
            while (k < m && !(h[i, k] > h[j, k]))
            {
                k++;
            }
            return k < m;
        }
    }
}
