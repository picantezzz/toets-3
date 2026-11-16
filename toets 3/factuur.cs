using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toets_3
{
    internal class factuur
    {

        public int FactuurID { get; set; }
        public int KlantID { get; set; }
        public string Klantnaam { get; set; }

        private int FactuurLijen;

        public int factuurlijnen
        {
            get { return factuurlijnen; }
            
        }

        public factuur(int factuurID,int klantID,string klantNaam)
        {

            factuurID = FactuurID;
            klantID = KlantID;
            klantNaam = Klantnaam;
        }
        public factuur()
        {

            Klantnaam = "";

        }

        public void voegFactuurlijnenToe(int aantal,string productnaam,double prijs)
        {
            Console.WriteLine($"{aantal} x (prijs = {prijs}euro/eenheid");

        }
        public double berekenFactuurtotaal()
        {
            double prijs = 0;
            int aantal = 0;
            double totaal;

            totaal = prijs * aantal;

            return totaal;
        }

        public string ToString()
        {
            string factnr;
            int nummer = 1;
            string naam = "";

            factnr = $"FactNr:{nummer++} - {naam}";
            return factnr;
        }

        
    }
}
