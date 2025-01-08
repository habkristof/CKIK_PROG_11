using System;


namespace meleg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int[,] h = new int[1000, 1000];
            Beolvas(h,  out n,  out m);

            

            //Console.WriteLine(VanEMax(maximum, n, m, h, 0));
            //Console.WriteLine(VanEMax(maximum, n, m, h, 1));
            //Console.WriteLine(VanEMax(maximum, n, m, h, 3));
            int[] melegek = Kivalogatas(h,n,m,  out int db);

            Kiir(melegek, db);
        }

        static void Kiir(int[] melegek, int db)
        {
            Console.WriteLine(db+" ");
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine(melegek[i]+1 + " ");
            }
        }

        static int[] Kivalogatas(int[,] h, int n, int m, out int db)
        {
            int maximum = Maximum(h, n, m);
            int[] melegek = new int[1000];
            db = 0;
            for (int i = 0; i < n; i++)
            {
                if (VanEMax(maximum, n, m, h, i))
                {
                    melegek[db] = i;
                    db++;
                }
                    
            }

        }

        static bool VanEMax(int maximum, int n, int m, int[,] h, int i)
        {
            int j =0;
            while (j < m && ! (h[i, j] == maximum))
            {
                j++;
            }
            return j < m;
        }

        

        static int Maximum(int[,] h, int n, int m)
        {
            int maxe = h[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (h[i, j] > maxe) 
                    {
                        maxe = h[i, j];
                    }
                }
            }
        }

        static void Beolvas(int[,] h,  out int n, out int m)
        {
            string[] sor = Console.ReadLine().Split(' ');// {"3" "5"}
            n = Convert.ToInt32(sor[0]);
            m = Convert.ToInt32(sor[1]);
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                sor = s.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    h[i, j] = Convert.ToInt32(sor[j]);
                }
            }
            Console.WriteLine(h[n - 1, m - 1]);

        }
    }
}
