using System;


namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] t = { 2, 7, 3 };
            // t[0]
            int[,] matrix = {
              { 8, 3, 21, 4 },
              { 1, -5, 7, 13 },
              { 3, 3, 10, -1 }
            };
            // matrix[0, 0]

            // F1
            Console.WriteLine(matrix[1, 2]); // 2. sor 3. eleme
            Console.WriteLine($"Elemek száma: {matrix.Length}");
            Console.WriteLine($"Sorok száma: {matrix.GetLength(0)}"); // dim1
            Console.WriteLine($"Oszlopok száma: {matrix.GetLength(1)}"); // dim2

            // F2
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++) // sorok bejárása
            {
                for (int j = 0; j < m; j++) // elemek bejárása
                {
                    if(j == matrix.GetLength(i) - 1 && 1 == matrix.GetLength(0)-1)
                    {
                        Console.Write(matrix[i, j]);  
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " , "); // i. sor j. eleme
                    }
                  
                }
                Console.WriteLine();
            }
            // F3
            Console.WriteLine("3. feladat");
            int osszeg = 0;
            for (int i = 0;i < n; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    osszeg += matrix[i, j];
                }
            }
            //f3.5
            
            //int maxi = 0;
            //int[] t = { 5, 7, -3, 2 };
            //int maxe = t[0];
            //for (int i = 1; i < n; i++)
            //{
            //    if (t[i] > maxi)
            //    {
            //        maxi = i;
            //        maxe = t[i];
            //    }
            //}

            //f4
            int maxi = 0;
            int maxj =0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; i++)
                {
                    if (matrix[maxi, maxj] < matrix[i, j])
                    {
                        maxi = i;

                    }
                }
            }
            Console.WriteLine($"{ maxi + 1},{ maxj+1}");

            //f5 sorok ossszege
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += matrix[i, j];
                }
                Console.Write(s + " ");
            }
            Console.WriteLine();

            //f5 oszlop
            for (int j = 0; j < m; j++)
            {
                int oszlopossszeg = 0;
                for (int i = 0; i < m; i++)
                {
                    oszlopossszeg += matrix[1, j];
                }
                Console.WriteLine(oszlopossszeg + " ");


            }
        }
    }
}

