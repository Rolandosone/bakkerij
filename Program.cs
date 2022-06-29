using System;
using System.Collections.Generic;

namespace Bakkerij_1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var medewerkerLijst = new List<Medewerker>();
            var klantLijst = new List<Klant>();
            var productLijst = new List<Product>();
            var doorgaan = true;


            Console.Title = "Bakkerij programma Roland van Ommeren";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White; Console.Clear();
            Console.WriteLine("\n\t\t----Welkom bij het Bakkerij programma----\n");
            

            Console.WriteLine("\nWilt u een medewerker toevoegen? Kies y/n");
            if (Console.ReadLine() == "y")
            {
                while (doorgaan)
                {
                    var medewerker = new Medewerker();

                    medewerkerLijst.Add(medewerker);

                    doorgaan = check();

                }
            }

            doorgaan = true;

            Console.WriteLine("\nWilt u een klant toevoegen? Kies y/n");
            if (Console.ReadLine() == "y")
            {
                while (doorgaan)
                {
                    var klant = new Klant();

                    klantLijst.Add(klant);

                    doorgaan = check();

                }

            }

            doorgaan = true;

            Console.WriteLine("\nWilt u een taart toevoegen? Kies y/n");
            if (Console.ReadLine() == "y")
            {
                while (doorgaan)
                {
                    var product = new Product();

                    productLijst.Add(product);

                    doorgaan = check();

                }

            }
            
            Console.WriteLine("\nDe bakkerij heeft de volgende medewerkers: ");
            foreach (var medewerker in medewerkerLijst)
            {
                medewerker.display();
            }
            Console.WriteLine("De bakkerij heeft de volgende klanten: ");
            foreach (var klant in klantLijst)
            {
                klant.display();
            }
            Console.WriteLine("De bakkerij heeft de volgende vlaaien te koop: ");
            foreach (var product in productLijst)
            {
                product.display();
            }
        }

        static bool check()
        {

            bool doorgaan = true;
            Console.WriteLine("Wilt u nog één toevoegen? y/n");

            if (Console.ReadLine() == "n")
            {
                doorgaan = false;
            }

            return doorgaan;

        }
    }
}
