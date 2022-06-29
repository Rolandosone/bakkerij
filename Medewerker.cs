using System;
using System.Collections.Generic;
using System.Text;

namespace Bakkerij_1_2_3
{
    internal class Medewerker:Persoon
    {
        public string Functie;

        public Medewerker()
        {
            Console.WriteLine("geef aub de functie op: ");
            Functie = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("Naam, Adres, Huisnummer en Functie: {0} {1} {2} {3} \n", Naam, Adres, Huisnummer, Plaatsnaam, Functie);
        }

    }
}
