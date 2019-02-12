using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Skolens
    {
        public string Vards;

        public string Uzvards;

        public string Epasts;

        public int DzimsanasGads;

        public Klase SkolenaKlase;

        public string SkolenaProfils()
        {
            return String.Format("Skolēna vārds ir {0} {1}. E-pasts: {2}, Dzimšanas gads: {3}", Vards, Uzvards, Epasts, DzimsanasGads);
        }
    }
}
