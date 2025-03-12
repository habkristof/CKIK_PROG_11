using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ember
{
    internal class Program
    {
        struct Ember
        {
            public int kor;
            public string nev;
            public double magassag;
        }
        static void Main(string[] args)
        {

            Ember bela;
            bela.nev = "Béla";
            bela.kor = 52;
            bela.magassag = 1.4;

            Ember lajos = new Ember { nev ="Lajos", kor = 12, magassag =1.23};

            Console.WriteLine($"Embereink nevei:{bela.nev} , {lajos.nev}");

            Bemutatkozas(bela);

        }

        static void Bemutatkozas(Ember bela)
        {
            
        }
    }
}
