using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szotar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> MagyarAngol = new Dictionary<string, string>();
            MagyarAngol.Add( "kutya", "dog");
            MagyarAngol.Add("macska", " cat");
            MagyarAngol.Add("oroszlán", "lion");
            MagyarAngol.Add("Alma", "apple");
            MagyarAngol.Add("Elefánt", "elephant");

            MagyarAngol.Remove("alma");


            Console.WriteLine("Szópárok száma:"  + MagyarAngol.Count);

            Console.WriteLine("Macska angolul:" + MagyarAngol["macska"]);

            
            Console.WriteLine("Az egér szót tudjuk-e angolul? " + MagyarAngol.ContainsKey("egér"));  // false
            Console.WriteLine("Tudjuk e magyarul a lion szót?" + MagyarAngol.ContainsValue("lion"));

            Kiir(MagyarAngol);

            // -----------------------------------------
            Console.Clear();

            List<string> gyumolcsok = new List<string> { "narancs", "alma", "Körte", "alma", "narancs", "alma","alma", "szilva","narancs" };
            Dictionary<string, int> mennyisegek = new Dictionary<string, int>();
            Megszamol(gyumolcsok, mennyisegek);
            Kiir(mennyisegek);
            
            Maximum(mennyisegek);
            Csakegydarab(mennyisegek);
            
            Console.ReadKey();

        }

        static void Csakegydarab(Dictionary<string, int> mennyisegek)
        {
            bool van = false;
            string keresettgyumolcs = "";
            foreach ( string elem in mennyisegek.Keys)
            {
                if (mennyisegek[elem] == 1)
                {
                    van = true;
                    keresettgyumolcs = elem;
                }
            }
            Console.WriteLine(keresettgyumolcs);
        }

        static void Maximum(Dictionary<string,int > mennyisegek)
        {
            int maxi = int.MinValue;
            string maxkulcs = "";
            foreach (string elem in mennyisegek.Keys)
            {
                
                if (mennyisegek[elem] > maxi)
                {
                    maxi = mennyisegek[elem];
                    maxkulcs = elem;
                }
                
            }
            Console.WriteLine("legtöbb gyümolcs fajtája:" + maxkulcs);
        }

        static void Megszamol(List<string> gyumolcsok, Dictionary<string, int> mennyisegek)
        {
            
            foreach (string elem in gyumolcsok)
            {
                if (mennyisegek.ContainsKey(elem))
                {
                    mennyisegek[elem]++;
                }
                else
                {
                    mennyisegek.Add(elem, 1);
                }
                
            }

        }

        static void Kiir<T>(Dictionary<string, T> szotar)
        {
            //Dictionary<string, string>.KeyCollection kulcsok = szotar.Keys;
            foreach (string kulcs in szotar.Keys)
            {
                Console.WriteLine(kulcs + " - " + szotar[kulcs]);
            }

        }
    }
}
