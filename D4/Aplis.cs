using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Aplis
    {
        /// <summary>
        /// Apļa rādiuss
        /// </summary>
        public double Radiuss; 
        /// <summary>
        /// Apļa krāsa
        /// </summary>
        public string Krasa;

        public Aplis(double Radiuss, string Krasa) // šis ir konstruktors, kuru var izsaukt objektā, lai to izveidotu
        {
            this.Radiuss = Radiuss;
            this.Krasa = Krasa;
        }

        public Aplis()
        {

        }

        public void KrasasIzvade()
        {
            Console.WriteLine("Krāsa ir {0}", Krasa);
        }
                
        public double Laukums() 
        {
            return 3.14 * (Radiuss * Radiuss);
        }

        public double Perimetrs()
        {
            return 2 * 3.14 * Radiuss;
        }
              
        public void KonsolesIzvade()
        {
            Console.WriteLine("Laukums ir {0}", Laukums());
            Console.WriteLine("Perimetrs ir {0}", Perimetrs());
            Console.WriteLine("Krāsa ir {0}", Krasa);
        }
    }
}
