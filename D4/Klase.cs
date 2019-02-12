using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Klase
    {
        public string Nosaukums;

        public int SkolēnuSkaits;

        public Telpa KlasesTelpa;

        public string KlasesProfils()
        {
            return String.Format("Klase: {0}, Skolēnu skaits: {1}", Nosaukums, SkolēnuSkaits);
        }
    }
}
