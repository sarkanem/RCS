using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Uzdevums("Piemers \n");
            CikluPiemers();
            Console.WriteLine();

            Uzdevums("1.uzdevums \n");
            Uzdevums1();
            Console.WriteLine();

            Uzdevums("2.uzdevums \n");
            Uzdevums2();
            Console.WriteLine();

            Uzdevums("3.uzdevums \n");
            Uzdevums3();
            Console.WriteLine();
            
            Uzdevums("4.uzdevums \n");
            Uzdevums4();
            Console.WriteLine();
                       
            Uzdevums("5.uzdevums \n");
            Uzdevums5();
            Console.WriteLine();
            Console.WriteLine();
           
            Uzdevums("6.uzdevums \n");
            Uzdevums6();
            Console.WriteLine();

            Console.ReadLine();
        }
        // int sk1 = Convert.ToInt32(Console.ReadLine());

        static void Uzdevums(string teksts) // lai atšķirtu uzdevuma nosaukumu
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(teksts);
            Console.ResetColor();
        }

        // for ( ; ; ) { do something };
        // for (int i=1; i<11; i++)
        // { Console.WriteLine("Tās galvaspilsēta ir Viļņa" + i) };

        static void CikluPiemers()
        {
            Console.WriteLine("Ievadi vienu skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            for (int i = skaitlis; i<=10; i++) // var arī uzreiz int skaitlis
            {
                
                 if (i == 5) // izlaiž 5, pāriet uz nākamo iterācju
                 { continue; }
           

                Console.WriteLine(i);

                /*
                if(i == 5) // lai pātrauktu cikla apstrādi
                {
                    break; // nostrādā uz tuvāko ciklu
                }
                */
            }
            Console.WriteLine("Cikla beigas");
        }

        static void Uzdevums1()
        {
            int summa = 0;

            for (int i = 1; i <= 100; i++) // viss kas ir ciklā atkārtojas
            {           

                Console.WriteLine(i);

                summa += i; // vai arī summa = summa + 1;

            }
            Console.WriteLine("Summa = {0}", summa);

            Console.WriteLine("Cikla beigas");
        }

        static void Uzdevums2()
        {
            Console.WriteLine("Ievadi savu dzimšanas gadu: ");

            int gads = Convert.ToInt32(Console.ReadLine());
            int robeza = DateTime.Now.Year;

            /*
            for (; gads <= robeza; gads++)
            {
                Console.WriteLine(gads);
            }  
            */

            while(gads <= robeza)
            {
                Console.WriteLine(gads);
                gads += 1;
            }
        }

        static void Uzdevums3()
        {
            Console.WriteLine("Ievadi skaitli: ");

            int skaitlis = int.Parse(Console.ReadLine());
            int summa = 0;
                   
            for (int i = 1; i <= skaitlis; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    summa += i;
                }
                /* otrs variants, ka nepāra izlaiž
                if (i % 2 != 0)
                {
                    continue;
                }
                    Console.WriteLine(i);
                    summa += i;
                */
            }
            Console.WriteLine("Summa ir {0}", summa);
        }

        static void Uzdevums4()
        {
            Console.WriteLine("Cik skaitļus ievadīsi?");
            int skaits = int.Parse(Console.ReadLine());

            int summa = 0;
            
            for (int i = 1; i <= skaits; i++)
            {
                Console.WriteLine("Ievadi {0}. skaitli", i);
                summa += int.Parse(Console.ReadLine());
                // int ievaditais = int.Parse(Console.ReadLine());
                // summa += ievaditais;                
            }
            Console.WriteLine("Summa ir {0}", summa);
            Console.WriteLine("Vidējā vērtība ir {0}", summa / (float)skaits);
        }

        static void Uzdevums5()
        {
            Console.WriteLine("Cik daudz restes gribi?");
            int restes = int.Parse(Console.ReadLine());

            for (int rinda = 1; rinda <= restes; rinda++)
            {
                for (int kolonna = 1; kolonna <= restes; kolonna++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }  
        }

        static void Uzdevums6()
        {
            Console.WriteLine("Cik lielu trijstūri gribi (no 1 līdz 10)?");
            int skaits = int.Parse(Console.ReadLine());

            for (int j = 1; j <= skaits; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();               
            }

            for (int k = skaits - 1; k >= 1; k--)
            {
                for (int i = 1; i <= k; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }
    }    
}
