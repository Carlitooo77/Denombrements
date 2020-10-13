using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
            /**
             * Titre : Denombrements
             * description : Calculer des Permutations, Arrangements et Combinaisons
             * auteur : Emds
             * date création : ?
             * date dernière modification : 13/10/20$
             */
        {
            int c = 1;
            while (c != 0)
            {
                // Menu
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                // Quitter
                if (c == 0) 
                { 
                    Environment.Exit(0); 
                }

                // Permutation
                if (c == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); 
                    int n = int.Parse(Console.ReadLine()); 
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                    {
                        r *= k;
                    }
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    // Arrangement
                    if (c == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int n = int.Parse(Console.ReadLine());
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                        {
                            r *= k;
                        }
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        // Combinaison
                        Console.Write("nombre total d'éléments à gérer = ");
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int n = int.Parse(Console.ReadLine());
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                        {
                            r1 *= k;
                        }
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                        {
                            r2 *= k;
                        }
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
