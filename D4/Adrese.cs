using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Adrese
    {        
        public string Valsts;
       
        public string Pilseta;

        public string Iela;

        public string PilnaAdrese()
        {
            return String.Format("{0}, {1}, {2}", Valsts, Pilseta, Iela);           
        }
    }
}
