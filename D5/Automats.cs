using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Automats
    {
        public double IemaksataSumma;

        public Automats(double IemaksataSumma)  //konstruktora nosaukums vienmēr sakrīt ar klases nosaukumu
        {
            this.IemaksataSumma = IemaksataSumma; 
        }

        public Automats()
        {

        }

        public void Iemaksat(double summa)
        {
            IemaksataSumma += summa;
            Console.WriteLine("Tu esi iemaksājis {0}", IemaksataSumma);
        }

        public void PirktDzerienu() 
        {
            if (IemaksataSumma <= 0.8)
            { 
                Console.WriteLine("Nepietiek līdzekļu");
            }
            else
            {
                IemaksataSumma -= 0.8;
                Console.WriteLine("Iegādāts dzēriens! Atlikms = EUR {0}", IemaksataSumma);
            }
        }

        public void SanemtAtlikumu()
        {
            Console.WriteLine("Tu saņēmi EUR {0}", IemaksataSumma);
            IemaksataSumma = 0;
        }
    }
}
