using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Telpa
    {
        public int Numurs;

        public int Stāvs;

        public string TelpasProfils()
        {
            return String.Format("{0}.telpa, {1}.stāvs", Numurs, Stāvs);
        }
    }
}
