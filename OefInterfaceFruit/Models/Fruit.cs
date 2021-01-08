using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefInterfaceFruit.Models
{
    public abstract class Fruit : IComparable<Fruit>
    {
        private readonly double prijsPerkg;
        public string  Naam { get; set; }
        public double PrijsPerk { get => prijsPerkg; }
        public object PrijsPerKg { get; private set; }

        protected Fruit(string naam, double prijsPerKg)
        {
            Naam = naam;
            this.prijsPerkg = prijsPerkg;
            
        }

        public override string ToString()
        {
            return $"Naam:{Naam} \tprijs: {PrijsPerKg}";
        }
        
        public int CompareTo(Fruit fruit)
        {
            return prijsPerkg.CompareTo(fruit.prijsPerkg);
        }
    }
}
