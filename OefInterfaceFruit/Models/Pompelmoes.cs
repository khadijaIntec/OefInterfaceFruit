using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefInterfaceFruit.Models
{
    class Pompelmoes : Fruit
    {
        public string  Kleur { get; set; }
        public Pompelmoes(string naam, double prijsPerkg, string kleur)
        {
            Kleur = Kleur;
        }
        public override string ToString()
        {
            return $"naam :{Naam} \tprijs: {PrijsPerKg} \tkleur: {Kleur}"; 
        }
    }
}
