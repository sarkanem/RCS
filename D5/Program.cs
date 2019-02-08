using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Uzdevums1();
            Uzdevums2();
            Uzdevums3();
            Uzdevums4();
            Uzdevums5();
            Uzdevums6();            
           */
            Uzdevums7(); 
            Console.ReadLine();
        }

        static void Uzdevums1()
        {
            Console.WriteLine("Ievadi skaitli: ");

            int skaitlis = Convert.ToInt32(Console.ReadLine());

            if (skaitlis % 3 == 0)
            { Console.WriteLine("Skaitlis dalās ar 3"); }
            else
            { Console.WriteLine("Skaitlis nedalās ar 3"); }

        }

        static void Uzdevums2()
        {
            Console.WriteLine("Ievadi skaitli: ");

            int skaitlis = Convert.ToInt32(Console.ReadLine());

            for (int i = skaitlis; i>=1; i--)
            { Console.WriteLine(i); }            
        }

        static void Uzdevums3()
        {
            Console.WriteLine("Ievadi skaitli: ");

            int skaitlis = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= skaitlis; i++)
            {
                if (i == 5)
                { continue; }
                else
                { Console.WriteLine(i); }
            }
        }

        static void Uzdevums4()
        {
            Console.WriteLine("Ievadi nedēļas dienu (P, O, T, C, Pk, Se, Sv): ");

            string diena = Console.ReadLine().ToUpper();

            Console.WriteLine("Vai es atvaļinājumā? (J/N)");

            string atvalinajums = Console.ReadLine().ToUpper();

            switch (diena)
            {
                case "P":
                case "O":
                case "T":
                case "C":
                case "PK":
                    switch (atvalinajums)
                    {
                        case "J":
                            {
                                Console.WriteLine("Modinātājs uzlikts uz 10:00");
                                break;
                            }
                        case "N":
                            {
                                Console.WriteLine("Modinātājs uzlikts uz 7:00");
                                break;
                            }

                    }
                    break;
                case "SE":
                case "SV":
                    switch (atvalinajums) // vai arī Console.WriteLine("atvalijanums == "J" ? "Off" : "10:00"); break;
                    {
                        case "J":
                            {
                                Console.WriteLine("Modinātājs nebūs");
                                break;
                            }
                        case "N":
                            {
                                Console.WriteLine("Modinātājs uzlikts uz 10:00");
                                break;
                            }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Neatļauta vērtība");
                    }
                    break;

            }

        }

        static void Uzdevums5()
        {
            Console.WriteLine("Ievadi pirmo skaitli: ");

            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi otru skaitli: ");

            int sk2 = Convert.ToInt32(Console.ReadLine());

            for (int i = sk1; i <= sk2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                { Console.WriteLine("FizzBuzz"); }

                else if (i % 3 == 0)
                { Console.WriteLine("Fizz"); }

                else if (i % 5 == 0)
                { Console.WriteLine("Buzz"); }

                else Console.WriteLine(i);                    
            }
            Console.WriteLine();
        }

        static void Uzdevums6()
        {
            Console.WriteLine("Ko Tu vēlies darīt? iemaksāt (1), pirkt (2), saņemt atlikumu (3), pārtraukt pirkumu (0)");

            int izvele = Convert.ToInt32(Console.ReadLine());

            Automats dzeriens = new Automats();

            while (izvele != 0) // ja būtu true tad vajag case 0 return nevis break, lai nostradatu uz visu ciklu
            {
                switch (izvele)
                {
                    case 1:
                        Console.WriteLine("Lūdzu veic iemaksu");
                        dzeriens.Iemaksat(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 2:
                        dzeriens.PirktDzerienu();
                        break;

                    case 3:
                        dzeriens.SanemtAtlikumu();
                        break;
                }
                Console.WriteLine("\niemaksāt (1), pirkt (2), saņemt atlikumu (3), pārtraukt pirkumu (0)");

                izvele = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Uzdevums7()
        {
            string vards = "BASEINS";
            string zv = "*******";
            int cikjamin = vards.Length; // cik burtu vārdā
           
            Console.WriteLine(zv);
            Console.WriteLine("Mini burtu!");                      
            
            string burts = Console.ReadLine().ToUpper();
            bool minejums = vards.Contains(burts); // true or false 
            
            // kamer nav zvaigznu atkārto

            while (zv.Contains("*"))
            { 
                if (minejums == false)
                { Console.WriteLine("Burts {0} nav šajā vārdā", burts);
                  break;
                }               

                else if (minejums == true)
                {
                    zv = zv.Remove(vards.IndexOf(burts), 1); // izņemt indeksēto 
                    zv = zv.Insert(vards.IndexOf(burts), burts); // ielikt minēto burtu
                    cikjamin = cikjamin-1;

                    Console.WriteLine(zv);
                    Console.WriteLine("Tev vēl jāuzmin {0} pozīcijas", cikjamin);
                    break;
                }
                
            }


            // Console.WriteLine(cikjamin + " burti"); 

            // int pozA = vards.IndexOf("A"); 0
            // pozA =  vards.IndexOf("A", 0+1); 2
            // pozA = vards.IndexOf("A", 2+1); -1

        }
    }
}


