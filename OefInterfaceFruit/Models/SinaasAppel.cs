using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefInterfaceFruit.Models
{
    class SinaasAppel: Fruit
    {
       
        public bool Soort { get; set; }
        public SinaasAppel(string naam, double prijsperk, bool soort):base (naam,prijsperk)
        {
            Soort = soort;
        }
        public override string ToString()
        {
            string soortText = "eetappelsien";
            if (!Soort)
            {
                soortText = "persappelsien";
            }

            return $"naam: { Naam} \tprijs: { PrijsPerKg} \tsoort: { Soort} ({ soortText})";

        }

    }

}
