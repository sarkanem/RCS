using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums("1.uzdevums \n");
            Vecums();
            Console.WriteLine();

            Uzdevums("2.uzdevums \n");
            Vienadiba();
            Console.WriteLine();

            Uzdevums("3.uzdevums \n");
            Menesi();
            Console.WriteLine();

            Uzdevums("4.uzdevums \n");
            Valstis();
            Console.WriteLine();

            Uzdevums("5.uzdevums \n");
            Operacija();
            Console.WriteLine();
            
            Uzdevums("6.uzdevums \n");
            Konvertacija();
            Console.WriteLine();
            

            Uzdevums("7.uzdevums \n");
            Pari();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void Uzdevums(string teksts) // lai atšķirtu uzdevuma nosaukumu
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(teksts);
            Console.ResetColor();
        }

        static void Vecums()
        {
            Console.WriteLine("Ievadi savu vecumu: ");
            int vecums = Convert.ToInt32(Console.ReadLine());
            if (vecums > 18) // == ir vienāds != nav vienāds
            {
                Console.WriteLine("Tu esi pilngadīgs!");
            }
            else if (vecums == 18)
            {
                Console.WriteLine("Tev ir tieši 18!");
            }
            else
            {
                Console.WriteLine("Tu vēl neesi pilngadīgs!");
            }
        }

        static void Vienadiba()
        {
            Console.WriteLine("Ievadi pirmo skaitli: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            if (sk1 == sk2)
            {
                Console.WriteLine("Skaitļi ir vienādi!");
            }       
            else
            {
                Console.WriteLine("Skaitļi nav vienādi");
            }
            // var arī saīsināt šādi: CONDITION ? TRUE : FALSE
            // ConsoleWrite(sk1 == sk2 ? "Skaitļi ir vienādi!" : "Skaitļi nav vienādi");
            // && un  || vai
        }

        static void Menesi()
        {
            Console.WriteLine("Ievadi mēnesi (piemēram, jan): ");
            string menesis = Console.ReadLine().ToLower(); // ja gadījumā ieraksta ar lielajiem burtiem tad būs lowercase

            if (menesis == "jan" || menesis == "mar" || menesis == "mai" || menesis == "jul" || menesis == "aug" || menesis == "okt" || menesis == "dec")
            {
                Console.WriteLine("Mēnesī ir 31 diena");
            }
            else if (menesis == "feb")
            {
                Console.WriteLine("Mēnesī ir 28 vai 29 dienas");
            }
            else
            {
                Console.WriteLine("Mēnesī ir 30 dienas");
            }
            // vēl var pierakstīt šādi, elegantāk un ātrāk:
            // switch(menesis) {
            // case "jan": 
            // case "mar": 
            // case "mai": utt.
            //      Console.WriteLine("Mēnesī ir 31 diena");
            //      break;
            // case "feb": 
            //      Console.WriteLine("Mēnesī ir 28 vai 29 dienas");
            //      break;
            // default: // nav obligāta
            //      Console.WriteLine("Mēnesī ir 30 dienas");
            //      break;}
        }

        static void Valstis()
        {
            Console.WriteLine("Nosauc savu mīļāko Baltijas valsti: ");
            string valsts = Console.ReadLine().ToLower();

            // ConsoleWrite("Valsts" + valsts + " galvaspilsēta ir");
            // ConsoleWrite("Valsts {0} galvaspilsēta {1}", valsts, "ir"); // šis ir labāks veids

            switch (valsts) {
                case "igaunija":
                    Console.WriteLine("Tās galvaspilsēta ir Tallina");
                    break;
                case "latvija":
                    Console.WriteLine("Tās galvaspilsēta ir Rīga");
                    break;
                case "lietuva":
                    Console.WriteLine("Tās galvaspilsēta ir Viļņa");
                    break;
                default:
                    Console.WriteLine("Šī valsts neatrodas Baltijā!");
                    break;
            }
        }

        static void Operacija()
        {
            Console.WriteLine("Izvēlies kādu no operācijām + , - , * , / ");
            string operacija = Console.ReadLine();

            Console.WriteLine("Ievadi pirmo skaitli");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            switch (operacija)
            {
                case "+":                
                    Console.WriteLine("Rezultāts ir " + (skaitlis1 + skaitlis2));
                    break;
                case "-":
                    Console.WriteLine("Rezultāts ir " + (skaitlis1 - skaitlis2));
                    break;
                case "*":
                    Console.WriteLine("Rezultāts ir " + (skaitlis1 * skaitlis2));
                    break;
                case "/":
                    Console.WriteLine("Rezultāts ir " + (skaitlis1 / (float)skaitlis2));
                    break;
                default:
                    Console.WriteLine("Tu ievadīji nepareizu operāciju");
                    break;
            }
        }

        static void Konvertacija()
        {
            Console.WriteLine("Ievadi grādus:");
            int gradi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kāda ir mērvienība? K, C vai F?");
            string tips = Console.ReadLine().ToUpper();

            Console.WriteLine("Uz kādu mērvienību pārvērst? K, C vai F?");
            string tips2 = Console.ReadLine().ToUpper();

            if (tips == tips2)
            {
                Console.WriteLine("Mērvienīvas ir vienādas");
            }

            switch (tips)
            {
                case "C":
                    if (tips2 == "K") // var arī switch te izmantot
                    {
                        Console.WriteLine(gradi + 273.15);
                    }
                    else if (tips2 == "F")
                    {
                        Console.WriteLine(gradi * 9 / 5 + 32);
                    }
                    break;
                case "F":
                    if (tips2 == "K")
                    {
                        Console.WriteLine(gradi - 32 / 1.8 + 273.15);
                    }
                    else if (tips2 == "C")
                    {
                        Console.WriteLine((gradi - 32) * 5/9);
                    }
                    break;
                case "K":
                    if (tips2 == "F")
                    {
                        Console.WriteLine((gradi - 273.15) * 1.8 + 32 );
                    }
                    else if (tips2 == "C")
                    {
                        Console.WriteLine(gradi - 273.15);
                    }
                    break;
                default:
                    Console.WriteLine("Tu ievadīji nepareizu mērvienību");
                    break;
            }
        }

        static void Pari()
        {
            Console.WriteLine("Ievadi skaitli");
            int sk = Convert.ToInt32(Console.ReadLine());

            if (sk % 2 == 0) // % ir dalījuma atlikums. Tātad, kad dala ar 2 nav decimāldaļu atlikumā jeb atlikums ir 0
                             // piemēram 5 % 2.2 = 0.6
                             // ielien 2 šādi 2.2 (kopā 4.4)
                             // paliek pāri 0.6 (5-4.4)

                             // 10 % 2 = 0
                             // ielien 5 tādi 2 (kopā 10)
                             // tātad atlikums ir 0 (10-10)
            {
                Console.Write("Skaitlis ir pāra");
            }
            else
            {
                Console.Write("Skaitlis ir nepāra");
            }
        }

    }
}
