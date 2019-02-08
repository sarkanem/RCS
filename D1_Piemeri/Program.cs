using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Piemeri
{
    class Program
    {
        static void Main(string[] args) // funkcija ir definēta un talāk ir funkciju izsaukumi
        {
            // izprintē tekstu
            Console.WriteLine("Hello world!");

            // izsaucam apakšējās funkcijas
            tekstaIzvade();
            tekstaIzvadeArParametru("teksts no funkcijas parametra");
            tekstaIevadeVards();
            vecumaIevade();

            // lai neaizvērtos logs
            Console.Read();
        }

        static void tekstaIzvade()
        {
            Console.WriteLine("Funkcijas izvadīts teksts");
        }

        static void tekstaIzvadeArParametru(string teksts) // lai izsauktu šo funkciju vienmēr ir nepieciešams viens parametrs
        {
            Console.WriteLine("Izvade " + teksts); // apvieno ar + zīmi
        }

        static void tekstaIevadeVards ()
        {
            //izvada
            Console.Write("Ievadi savu vārdu: ");

            //ievada
            string vards = Console.ReadLine();

            Console.Write("Ievadi savu uzvārdu: ");

            string uzvards = Console.ReadLine();

            //izvada rezultātu
            Console.WriteLine("Tevi sauc " + vards + " " + uzvards);
        }

        static void vecumaIevade ()
        {
            Console.Write("Ievadi savu vecumu: ");

            // string vecums = Console.ReadLine();
            // int skaitlis = Convert.ToInt32(vecums); vai = int.Parse(vecums);
            int skaitlis = Convert.ToInt32(Console.ReadLine()) + 1;
            // skaitlis = skaitlis + 1;
            // vai
            // skaitlis += 1;

            Console.Write("Pēc gada Tev būs " + skaitlis);
        }
        
    }
}
