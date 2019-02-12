using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9
{
    class Kvadrats : Taisnsturis // konstruktori nemantojas
    {
        public Kvadrats(double mala) : base(mala, mala) // tas ir konstruktors jo nosaukums sakrīt ar klasi un nav datu tips (string, double utt.)
        {
            // vai arī  base(mala, mala) vietā likt:
            // Mala1 = mala;
            // Mala2 = mala;
        }

        public override string Nosaukums()
        {
            return "Kvadrāta";
        }
    }
}
