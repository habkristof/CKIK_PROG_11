using System;

namespace idojaras
{
    static void Beolvas(int[,] h, out int n, out int m)
    {
        string[] sor = Console.ReadLine().Split(' ');
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
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
