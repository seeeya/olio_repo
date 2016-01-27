using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioreeniä
{
    class Elintarvike
    {
        //PRIVATE SHIT DO NOT TOUCH
        private string tuote;
        private readonly string paivays;
        private readonly double hinta;
        private int maara;
        //public shit
        public string Tuote
        {
            get { return tuote; }
            set { 
                    tuote = value;
                }
        }
        public Elintarvike()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Elintarvike(string tuote, string paivays, int maara, double hinta) 
   
        {
            this.tuote = tuote;
            this.paivays = paivays;
            this.maara = maara;
            this.hinta = hinta;
        }
        public string Paivays
        {
            get { return Paivays; }
        }
        public override string ToString()
        {
            return tuote + " | " + paivays + " | " + maara + " kpl | " + hinta + "e ";

        }

    }
    class Alkoholi : Elintarvike
    {
        public string Vahvuus { get; set; }
        public Alkoholi()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Alkoholi(string Tuote, string Vuosikerta, string vahvuus,int maara, double hinta) 
            : base(Tuote,Vuosikerta, maara, hinta)
        {
            Vahvuus = vahvuus;
        }
        public override string ToString()
        {
            return base.ToString() + " | " + Vahvuus + " %";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Elintarvike Banaani = new Elintarvike("Chiquita Banaani", "27.1.2016", 600, 5.5);
            Alkoholi Vodka = new Alkoholi("Saaremaa Vodka", "2015", "40", 600, 20.5);
            Console.WriteLine(Banaani.ToString());
            Console.WriteLine(Vodka.ToString());
           
        }
    }
}
