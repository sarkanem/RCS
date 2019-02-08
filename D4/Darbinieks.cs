using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Darbinieks
    {
        public string Vards;

        public string Uzvards;

        public Adrese Dzivesvieta;

        public Adrese Darbavieta;

        public void DarbiniekaProfils()
        {
            Console.WriteLine("Vārds ir {0} {1}", Vards, Uzvards); 
        }
    }
}
