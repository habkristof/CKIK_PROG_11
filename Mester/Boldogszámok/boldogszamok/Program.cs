using System;


namespace boldogszamok
{
    internal class Program
    {
        static int negyzetosszeg(int n)
        {
            string szam = Convert.ToString(n);
            int osszeg = 0;
            for (int i = 0; i < szam.Length; i++)
            {
                int jegy = Convert.ToInt32(Convert.ToString(szam[i]));
                osszeg += jegy * jegy;
            }
            return osszeg;
        }
        static bool BoldogE(int n)
        {
            while(n >= 10)
            {
                n = negyzetosszeg(n);
            }
            return n == 1 || n == 7;
        }


        static void Main(string[] args)
        {
            //Console.WriteLine(negyzetosszeg(23)); //13
            //Console.WriteLine(negyzetosszeg(135)); // 35
            //Console.WriteLine(BoldogE(15));
            //Console.WriteLine(BoldogE(23));
            int a, b;
            string[] sor = Console.ReadLine().Split();
            a = Convert.ToInt32(sor[0]);
            b = Convert.ToInt32(sor[1]);
            for (int i = a; i <= b; i++)
            {
                if (BoldogE(i))
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
