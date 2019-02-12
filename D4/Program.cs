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
            /*
            Uzdevums("1. uzdevums");
            Uzdevums21();
            Console.WriteLine();

            Uzdevums("Aplis");
            AplisUzdevums();
            Console.WriteLine();

            Uzdevums("Darbinieks");
            Darbinieks();
            Console.WriteLine();
            */

            Uzdevums("E-Klase");
            EKLASE();
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

        static void EKLASE()
        {
            Vertejums jauns = new Vertejums();
           
            jauns.Atzime = 8;
            jauns.MacibuPrieksmets = new Prieksmets
            {
                Nosaukums = "Algebra",
            };

            jauns.MacibuPrieksmets.PrieksmetaTelpa = new Telpa
            {
                Numurs = 201,
                Stāvs = 2
            };

            jauns.MacibuPrieksmets.PrieksmetaSkolotajs = new Skolotajs
            {
                Vards = "Jana",
                Uzvards = "Zaķe",
                Epasts = "zakis@skola.lv",
            };

            jauns.SkolenaProfils = new Skolens
            {
                Vards = "Jānis",
                Uzvards = "Lūsis",
                Epasts = "lusis@skola.lv",
                DzimsanasGads = 2001
            };

            jauns.SkolenaProfils.SkolenaKlase = new Klase
            {
                Nosaukums = "11B",
                SkolēnuSkaits = 28
            };

            jauns.SkolenaProfils.SkolenaKlase.KlasesTelpa = new Telpa
            {
                Numurs = 401,
                Stāvs = 4
            };

            // Skolens sk = new Skolens();
            // sk.Klase = new Klase();
            // sk.Klase.Telpa = new Telpa();
            // Skolens.Klase.Telpa.Numurs = 5;

            jauns.VertejumaProfils();
            Console.WriteLine(jauns.MacibuPrieksmets.PrieksmetaProfils());
            Console.WriteLine(jauns.MacibuPrieksmets.PrieksmetaTelpa.TelpasProfils());
            Console.WriteLine(jauns.MacibuPrieksmets.PrieksmetaSkolotajs.SkolotajaProfils());
            Console.WriteLine(jauns.SkolenaProfils.SkolenaProfils());
            Console.WriteLine(jauns.SkolenaProfils.SkolenaKlase.KlasesProfils());
            Console.WriteLine(jauns.SkolenaProfils.SkolenaKlase.KlasesTelpa.TelpasProfils());
        }
    }
}
