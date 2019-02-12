using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Prieksmets
    {
        public string Nosaukums;
        
        public Telpa PrieksmetaTelpa;

        public Skolotajs PrieksmetaSkolotajs;

        public string PrieksmetaProfils()
        {
            return String.Format("Priekšmets ir {0}", Nosaukums);
        }
    }
}
