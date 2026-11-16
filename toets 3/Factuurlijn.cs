using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toets_3
{
    internal class Factuurlijn
    {

        public int Aantal { get; set; }
        public int Prijs { get; set; }
        public string Productnaam { get; set; }



        public Factuurlijn(int aantal, double prijs,string productnaam)
        {
            aantal = Aantal;
            prijs = Prijs;
            productnaam = Productnaam;

        }
        public Factuurlijn()
        {

            Productnaam = "";
            Aantal = 0;
            
        }
        public string ToString()
        {



        }
    }
}
