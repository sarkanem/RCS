using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Kvadrats // visi aprēķini
    {
        public int malasGarums; //ipašība

        public Kvadrats (int malasGarums/*,citi parametri*/) //konstruktors sakrīt ar klases nosaukumu
        {
            this.malasGarums = malasGarums; // this attiecas uz augšējo, klases mainīgo
        }

        public Kvadrats() 
        {
           
        }

        public int Laukums () //funkcija
        {
            return malasGarums * malasGarums;
        }

        public int Perimetrs ()
        {
            return malasGarums * 4;
        }

        public void KonsolesIzvade () // nav return tāpēc void
        {
            Console.WriteLine("Laukums ir {0}", Laukums());
            Console.WriteLine("Perimetrs ir {0}", Perimetrs());
        }

        public static void FigurasNosaukums ()
        {
            Console.WriteLine("Šis ir kvadrāts!");
        }


    }
}
