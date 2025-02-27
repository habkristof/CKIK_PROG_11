using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace rendezes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch ora = new Stopwatch();
            //List<int> lista = new List<int>{5,3,7,5,2};

          

            List<int> lista = Feltolt(20);
            Kiir(lista,"Eredeti lista :");

            List<int> a = new List<int>(lista);
            ora.Start();
            a.Sort(); // növekvő
            ora.Stop();
            long idoSort = ora.ElapsedTicks;
            Kiir(a,"sort rendezés");

            List<int> b = new List<int>(lista);
            ora.Restart();
            MinRendez(b);
            ora.Stop();
            long MinidoSort = ora.ElapsedTicks;
            Kiir(b, "Minimum kiválasztás rendezés");

            Console.WriteLine($"Sort ideje:" + idoSort);
            Console.WriteLine($"Sort ideje:" + MinidoSort);

            
            List<int> c = new List<int>(lista);
            Buborekos(c);
            
            List<int> d = new List<int>(lista);
            ora.Restart();
            Beszuras( ref d);
            ora.Stop();
            long idobeszuras = ora.ElapsedTicks;

        }

        static void Beszuras( ref List<int> lista)
        {
            List<int> Rendezett = new List<int>();
            foreach (int  elem  in lista)
            {
                int i = 0;
                while (i < Rendezett.Count && !(Rendezett[i] >= elem))
                {
                    i++;
                }
                if (i < Rendezett.Count)
                {
                    Rendezett.Insert(i, elem);
                }
                else
                {
                    Rendezett.Insert(Rendezett.Count, elem);
                }
            }
            lista = Rendezett;
           
        }

        static void Buborekos(List<int> lista)
        {
            int n = lista.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if(lista[i] > lista[j+1])
                    {
                        Csere(lista, j, j +1);
                    }
                }
            }
        }

        static List<int> Feltolt(int n)
        {
            Random r = new Random();
            List<int> eredmeny = new List<int>();
            for (int i = 0; i < n; i++)
            {
                eredmeny.Add(r.Next(1,101));
            }
            return eredmeny;
        }

        static void Kiir(List<int> lista, string szöveg)
        {
            Console.WriteLine(szöveg);
            foreach (int elem in lista)
            {
                Console.WriteLine(elem + " ");
            }
            Console.WriteLine();
        }

        static void MinRendez(List<int> lista)
        {
            for (int i = 0; i < lista.Count -1; i++) 
            {
                int minj = i;
                for(int j = minj + 1; j < lista.Count; j++)
                {
                    if (lista[j] < lista[minj])
                    {
                        minj = j;
                    }
                }
                Csere(lista, i, minj);
            }
            
        }

        static void Csere(List<int> lista, int i, int j)
        {
            //int seged = lista[i];
            //lista[i] = lista[j];
            //lista[j] = seged;
            (lista[j], lista[i]) = (lista[i], lista[j]);
        }
    }
}
