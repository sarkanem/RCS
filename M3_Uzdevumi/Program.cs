using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Uzdevums("Uzdevums no trešās dienas \n");
            UzdevumsD3();
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
                        
            Uzdevums("6.uzdevums \n");
            Uzdevums6();
            Console.WriteLine();
            */
            
            Uzdevums("7.uzdevums \n");
            Uzdevums7();
            Console.WriteLine();

            Console.Read();
        }

        static void Uzdevums(string teksts)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(teksts);
            Console.ResetColor();
        }

        static void UzdevumsD3()
        {
            Console.WriteLine("Cik zvaigznes vēlies?");
            int zv = int.Parse(Console.ReadLine());

            int i, j, cipars;

            for (i = 1; i <= zv; i++)
            {
                for (j = 1; j <= zv - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= i * 2 - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            cipars = 1;
            for (i = 1; i <= zv - 1; i++)
            {
                for (j = 1; j <= cipars; j++)
                    Console.Write(" ");
                cipars++;
                for (j = 1; j <= 2 * (zv - i) - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void Uzdevums1()
        {
            Console.WriteLine("Ievadi savu vecumu: ");

            int vecums = Convert.ToInt32(Console.ReadLine());

            if (vecums <= 50)
            {
                Console.WriteLine("Tev ir zem 50 gadiem");
            }
            else
            {
                Console.WriteLine("Tu ir virs 50 gadiem!");
            }
        }

        static void Uzdevums2()
        {
            Console.WriteLine("Ievadi skaitli: ");

            int skaitlis = Convert.ToInt32(Console.ReadLine());

            if (skaitlis >= -50 && skaitlis <= 50)
            {
                Console.WriteLine("Skaitlis ietilpst intervālā");
            }
            else
            {
                Console.WriteLine("Skaitlis neietilpst intervālā");
            }
        }

        static void Uzdevums3()
        {
            Console.WriteLine("Ievadi skaitli");
            int sk = Convert.ToInt32(Console.ReadLine());

            if (sk % 2 == 0)
            {
                Console.Write("Skaitlis ir pāra");
            }
            else
            {
                Console.Write("Skaitlis ir nepāra");
            }
        }

        static void Uzdevums4() // vai te varētu izmantot switch?
        {
            Console.WriteLine("Ievadi pirmo skaitli");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi otro skaitli");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi trešo skaitli");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2)
            {
                if (sk1 > sk3)
                {
                    Console.Write("Pirmais skaitlis ir lielākais");
                }
                else
                {
                    Console.Write("Trešais skaitlis ir lielākais");
                }
            }
            else if (sk2 > sk3)
                Console.Write("Otrais skaitlis ir lielākais");
            else
                Console.Write("Trešais skailis ir lielākais");

            // int min = Math.Min(sk1,sk2);
        }

        static void Uzdevums5()
        {
            Console.WriteLine("Ievadi skaitli");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            int summa = 0;
            while (skaitlis != 0)
            {
                summa += skaitlis % 10;
                skaitlis /= 10;
            }
            Console.WriteLine("Skaitļa summa ir " + summa);
        }

        static void Uzdevums6()
        {
            int skaitlis = 0;
            int summa = 0;
            
            while (skaitlis != 13) // vai arī nedefinēt skaitli un vnk rasktīt (true) vai for (;;)
            {
                Console.WriteLine("Ievadi skaitli: ");
                int cip = Convert.ToInt32(Console.ReadLine());
                summa += cip;
                if (cip == 13) { break; }
            }

            Console.WriteLine(summa-13);
        }

        static void Uzdevums7()
        {
            Random random = new Random();
            int cipars = random.Next(1,100);
            int minejums = 0;
          
            while (minejums != cipars)
            {
                Console.WriteLine("Mini skaitli: ");
                int min = Convert.ToInt32(Console.ReadLine());
                if (min == cipars) { Console.WriteLine("Tu uzminēji! "); break; };
                if (min >= cipars) { Console.WriteLine("Tavs ievadītais cipars ir lielāks par atminējumu \n"); };
                if (min <= cipars) { Console.WriteLine("Tavs ievadītais cipars ir mazāks par atminējumu \n"); };                               
            }

        }
    }
}