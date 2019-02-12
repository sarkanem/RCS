using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Skolotajs
    {
        public string Vards;

        public string Uzvards;

        public string Epasts;
               
        public string SkolotajaProfils()
        {
            return String.Format("Skolotāja vārds ir {0} {1}. E-pasts: {2}", Vards, Uzvards, Epasts);
        }
    }
}
