using System;
using System.Collections.Generic;
using System.Text;

namespace Bakkerij_1_2_3
{
    internal class Product
    {
        public int Vlaainummer;
        public string Vlaaitype;

        public Product()
        {

            Console.WriteLine("Geef aub het vlaainummer op: ");
            Vlaainummer = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef aub het vlaaitype op: ");
            Vlaaitype = Console.ReadLine();

        }
        public void display()
        {
            Console.WriteLine("Vlaainaam: {0} {1} \n", Vlaainummer, Vlaaitype);
        }
    }
}
