using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiralyok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            List<int> kezdet = new List<int>();
            List<int> idotartam = new List<int>();
            Beolvas(nevek, kezdet, idotartam);
            Rendezes(idotartam);
        }

        static void Rendezes(List<int> idotartam)
        {
           for (int i = 0; i < idotartam.Count; i++)
            {
                int maxi = i;
                for (int j = i; j < idotartam.Count; j++)
            }
        }

        static void Beolvas(List<string> nevek, List<int> kezdet, List<int> idotartam)
        {
            StreamReader reader = new StreamReader("adatok.txt");
            while (!reader.EndOfStream)
            {
                string sor = reader.ReadLine();
                string[] adatok = sor.Split(',');
                nevek.Add(adatok[0]);
                kezdet.Add(int.Parse(adatok[1]));
                idotartam.Add(int.Parse(adatok[2]));
            }
            reader.Close();
        }
    }
}
