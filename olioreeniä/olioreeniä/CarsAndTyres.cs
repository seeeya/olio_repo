using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioreeniä
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Modell { get; set; }
        public void RemoveTyres()
        {
            tyres.Clear();
        }
        public void AddTyre(Tyre t)
        {
            tyres.Add(t);
        }
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Modell = model;
            tyres = new List<Tyre>();
            AddTyre(new Tyre("Nokian", "Hakkapeliitta", "205R16"));
            AddTyre(new Tyre("Nokian", "Hakkapeliitta", "205R16"));
            AddTyre(new Tyre("Nokian", "Hakkapeliitta", "205R16"));
            AddTyre(new Tyre("Nokian", "Hakkapeliitta", "205R16"));

        }
        public override string ToString()
        {
            string s = "Vehicle: " + Brand + " || Model: " + Modell;
            foreach(Tyre t in tyres)
            {
                s += "\n";
                s += t.ToString();
            }
            return s;
        }
        public List<Tyre> tyres;

    }
    
   
    class Tyre
    {
        public string Brand { get; set; }
        public string Modell { get; set; }
        public string Size { get; set; }
        public Tyre(string brand, string model, string size)
        
        {
            Brand = brand;
            Modell = model;
            Size = size;
        }
        public override string ToString()
        {
            return "Tyre: " + Brand + ": " + Modell + " Size: " + Size; 
        }
      
    }
}
