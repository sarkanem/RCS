using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9
{
    interface IGeometriskaFigura       // interfeiss pasaka kāda būs kase. Tās metodes, kas te ir jābūt klasē
    {
        double Laukums();

        double Perimetrs();

        string Nosaukums();
    }
}
