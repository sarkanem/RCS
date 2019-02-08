using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1_Uzdevumi
{
    class Program
    {
        static void Main()
        {
            Uzdevums("1.uzdevums, V.1. \n");           // \n ieliek tukšu līniju starpā  
            Uzdevums1();
            Console.WriteLine();

            Uzdevums("1.uzdevums, V.2. \n");
            Uzdevums1_2();
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

            Console.Read();

        }

        static void Uzdevums(string message) // lai atšķirtu uzdevuma nosaukumu
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Uzdevums1() // pirmais variants
        {
            Console.WriteLine("  *");
            Console.WriteLine(" ***");
            Console.WriteLine("*****");
        }

        static void Uzdevums1_2() // otrs variants
        {
            int i, j;

            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j <= 3 - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }

        static void Uzdevums2()
        {
            Console.WriteLine("Ievadi pirmo vārdu: ");
            string pirmais = Console.ReadLine();
            Console.WriteLine("Ievadi otro vārdu: ");
            string otrais = Console.ReadLine();
            Console.WriteLine("Ievadi trešo vārdu: ");
            string tresais = Console.ReadLine();
            Console.WriteLine("Tu ievadīji: " + pirmais + ", " + otrais + ", " + tresais);
        }

        static void Uzdevums3() // par rezultātiem jāpārliecinās
        {
            Console.WriteLine("Ievadi ciparu: ");
            int cipars = Convert.ToInt32(Console.ReadLine());
            // cipars = 4
            float r1 = cipars + 5; // = 9
            float r2 = cipars += 5; // = 9 // vienādojuma zīme  liek paturēt iepriekšējo value
            float r3 = cipars -= 3; //  = 9-3=6
            float r4 = cipars *= 2; // 6*2=12
            float r5 = cipars + 1;  // 12+1=13  // a= a+1 tas pats kas a+=1 tas pats kas a++
            float r6 = cipars += 1;
            float r7 = cipars++;


            Console.WriteLine("1.rezultāts " + r1);
            Console.WriteLine("2.rezultāts " + r2);
            Console.WriteLine("3.rezultāts " + r3);
            Console.WriteLine("4.rezultāts " + r4);
            Console.WriteLine("5.rezultāts " + r5);
            Console.WriteLine("6.rezultāts " + r6);
            Console.WriteLine("7.rezultāts " + r7);

        }

        static void Uzdevums4()
        {
            Console.WriteLine("Ievadi savu vārdu: ");
            string vards = Console.ReadLine(); // var arī te likt .ToUpper()
            Console.WriteLine(vards.ToUpper());
        }

        static void Uzdevums5()
        {
            Console.WriteLine("Ievadi savu vecumu: ");
            int vecums = Convert.ToInt32(Console.ReadLine());
            if (vecums < 18)
            {
                Console.WriteLine("Tu vēl neesi pilngadīgs!");
            }
            else
            {
                Console.WriteLine("Tu esi pilngadīgs!");
            }
        }
    }

}
