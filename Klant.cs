using System;
using System.Collections.Generic;
using System.Text;

namespace Bakkerij_1_2_3
{
    internal class Klant:Persoon
    {
        public int Klantnummer;

        public Klant()
        {

            Console.WriteLine("geef aub het klantnummer op: ");
            Klantnummer = int.Parse(Console.ReadLine());


        }

        public void display()
        {
            Console.WriteLine("Klantnummer, Naam, Adres, Huisnummer en Plaats: {0} {1} {2} {3} {4} \n", Klantnummer, Naam, Adres, Huisnummer, Plaatsnaam);
        }
    }
}
