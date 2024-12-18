using System;


namespace allatok
{
    internal class Program
    {
        static void Beolvas(string[] bal, string[] jobb, out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split(' '); // {"roka", "fogoly"}
                bal[i] = sor[0]; // "roka"
                jobb[i] = sor[1]; // "fogoly"
            }
        }

        static bool Eleme(string s, string[] t)
        {
            int i = 0;
            while (i < t.Length && !(t[i] == s))
            {
                i++;
            }
            return i < t.Length;
            
        }
         
        static void Kivalogat(string[] bal, string[] jobb, int n, string[] allatok, out int db)
        {
            db = 0;
            for (int i = 0; i < n; i++)
            {
                // Eleme-e a jobb oldali "lény" a bal oldali tömbnek?
                if (Eleme(jobb[i], bal) && !Eleme(bal[i],allatok))
                {
                    allatok[db] = bal[i]; 
                    db++;
                }
            }
        }




        static void Kiir(string[] allatok, int db)
        {
            Console.WriteLine(db);
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine(allatok[i]);
            }
        }

        static void Main(string[] args)
        {
            string[] bal = new string[30];
            string[] jobb = new string[30];
            Beolvas(bal, jobb, out int n);

            string[] allatok = new string[30];
            Kivalogat(bal, jobb, n, allatok, out int db);

            Kiir(allatok, db);
        }
            
    }
}
