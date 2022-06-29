using System;
using System.Collections.Generic;
using System.Text;

namespace Bakkerij_1_2_3
{
    internal class Persoon
    {
        public string Naam;
        public string Adres;
        public int Huisnummer;
        public string Plaatsnaam;

        public Persoon()
        {
            Console.WriteLine("Geef aub de naam op: ");
            Naam = Console.ReadLine();

            Console.WriteLine("Geef aub het adres op: ");
            Adres = Console.ReadLine();

            Console.WriteLine("Geef aub het huisnummer op: ");
            Huisnummer = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef aub de plaatsnaam op: ");
            Plaatsnaam = Console.ReadLine();
        }

    }
}
