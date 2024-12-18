using System;


namespace Sutemeny
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1-es adatok beolvasása
            int n = Convert.ToInt32(Console.ReadLine());

            string[] osztaly = new string[100];
            int[] kostolta = new int[100];
            double[] pontszam_atlag = new double[100];

            int i;

            for ( i = 0; i < n; i++)
            {
                string sor = Console.ReadLine();
                string[] adatok = sor.Split(' ');
                osztaly[i] = adatok[0];
                kostolta[i] = Convert.ToInt32(adatok[1]);

            }

            //  2-es megszámlálás függvény

            int db = 0;
            for ( i = 0; i < n; i++)
            {
                if (kostolta[i] == 45)
                {
                    db++;
                }
            }
            Console.WriteLine($"2-es feladat : {db}");

            // 3-as  maximum kiválasztás

            double maxertek = pontszam_atlag[0];
            for(i = 0; i < n ; i++)
            {
                if (pontszam_atlag[i] > maxertek)
                {
                    maxertek = i;
                }
            }
            Console.WriteLine($"3-as feladat : {osztaly[i]}");


            // 4-es keresés tétel

            while (i < n && !(pontszam_atlag[i] < 1 && kostolta[i] > 40));
            {
                i++;
            }
            if(i < n)
            {
                Console.WriteLine($" 4-es feladat:{osztaly[i]}");
            }
            else
            {
                Console.WriteLine("nincs ilyen");
            }


            // 5-os Összegzés tétel

            double összeg = 0;
            for (i = 0; i < n; i++)
            {
                összeg = kostolta[1];
            }
            Console.WriteLine($"5-os feladat: {összeg}");
            


            
        }
    }
}
