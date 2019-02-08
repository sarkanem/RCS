using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Program
    {
        static void Main(string[] args)
        {

            Uzdevums("1. uzdevums \n");
            Uzdevums21();
            Console.WriteLine();

            Uzdevums("Aplis");
            AplisUzdevums();
            Console.WriteLine();

            Uzdevums("Darbinieks");
            Darbinieks();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void Uzdevums(string teksts) // lai atšķirtu uzdevuma nosaukumu
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(teksts);
            Console.ResetColor();
        }

        static void Uzdevums21()
        {

            Kvadrats kv1 = new Kvadrats(); // kamēr nebija šīs līnijas kvadrāts nebija (atmiņu neaizņēm), objektiem vienmēr priekšā ir new, primitīvajiem nevajag

            kv1.malasGarums = 5;

            int laukums = kv1.Laukums();
            int perimetrs = kv1.Perimetrs();

            Console.WriteLine("Laukums ir {0}", laukums);
            Console.WriteLine("Perimetrs ir {0}", perimetrs);

            Kvadrats kv2 = new Kvadrats(10);

            Console.WriteLine("Laukums ir {0}", kv2.Laukums());
            Console.WriteLine("Perimetrs ir {0}", kv2.Perimetrs());

            Kvadrats kv3 = new Kvadrats()
            {
                malasGarums = 5,

            // ...un pārējās īpašības


            // tas pats kas
            // Kvadrats kv3 = new Kvadrats ();
            // kv3.malasGarums = 5;             
            };

            Kvadrats.FigurasNosaukums();

            Kvadrats kv4 = new Kvadrats(10);
            kv4.KonsolesIzvade();
        }

        static void AplisUzdevums()
        {

            Aplis ap1 = new Aplis(); // kamēr nebija šīs līnijas kvadrāts nebija (atmiņu neaizņēm), objektiem vienmēr priekšā ir new, primitīvajiem nevajag

            ap1.Radiuss = 5;
            ap1.Krasa = "sarkans";

            double laukums = ap1.Laukums();
            double perimetrs = ap1.Perimetrs();
          
            Console.WriteLine("Laukums ir {0}", laukums);
            Console.WriteLine("Perimetrs ir {0}", perimetrs);
            ap1.KrasasIzvade();

            Aplis ap2 = new Aplis(10, "zils");
            ap2.KonsolesIzvade();
          
        }

        static void Darbinieks()
        {

            Darbinieks darb = new Darbinieks();

            darb.Vards = "Aigars";
            darb.Uzvards = "Liepa";
            darb.Dzivesvieta = new Adrese
            {
                Valsts = "Latvija",
                Pilseta = "Rīga",
                Iela = "Jāņa iela"
            };
            darb.Darbavieta = new Adrese
            {
                Valsts = "Latvija",
                Pilseta = "Rīga",
                Iela = "Stūru iela"
            };

            darb.DarbiniekaProfils();
            Console.WriteLine("Darbinieka dzīvesvieta: {0}", darb.Dzivesvieta.PilnaAdrese());
            Console.WriteLine("Darbinieka darbavieta: {0}", darb.Darbavieta.PilnaAdrese());
        }

    }
}
