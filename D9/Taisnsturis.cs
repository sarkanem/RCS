using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9
{
    class Taisnsturis : IGeometriskaFigura  // : ir mantošana
    {
        public double Mala1;

        public double Mala2;

        public Taisnsturis()
        {
        }

        public Taisnsturis(double mala1, double mala2)
        {
            Mala1 = mala1;
            Mala2 = mala2;
        }    

        public double Laukums()
        {
            return Mala1 * Mala2;
        }

        public virtual string Nosaukums() // virtual ļauj šo klasi pārrakstīt, kad to manto
        {
            return "Taisntūra";
        }

        public double Perimetrs()
        {
            return (Mala1 + Mala2) * 2;
        }
    }
}
