using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Piemers();
            Uzdevums25();            
            Uzdevums26();            
            pretejiSaraksts();
            Uzdevums27();
            */
            Uzdevums28();
            Console.ReadLine();
        }

        static void Piemers()
        {
            int[] skaitli = new int[5]; // masīvs ar 5 int elementiem 
            skaitli[0] = 1;
            skaitli[1] = 2;
            skaitli[2] = 3;
            skaitli[3] = 4;
            skaitli[4] = 5;
            // skaitli[5] = 6; // izmetīs kļūdu IndexOutOfRange

            int skaitlis = skaitli[3]; // 4

            for(int i = 0; i < 5; i++) // vi i < 5 va likt skaitli.Length
            {
                int vertibas = skaitli[i];
                Console.WriteLine(vertibas);
            }
            
            // vai arī šādi
            // foreach (... in masivs)
            foreach(int vertibas in skaitli)
            {
                Console.WriteLine(vertibas);
            }                   
        }

        static void Uzdevums25()
        {
            Console.WriteLine("Ievadi skaitli: ");

            int skaitlis = Convert.ToInt32(Console.ReadLine());

            int[] masivs = { 0, 10, 20, 30, 40, 50 };

            bool irAtrasts = false;
            
            for (int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] == skaitlis)
                {
                    Console.WriteLine("Skaitlis atrasts pozīcijā {0}", i);
                    irAtrasts = true;
                    break; // lai neturpinātu meklēt
                }
            }

            if (irAtrasts == false) // var pierakstīt arī if(!irAtrasts)
            { 
                Console.WriteLine("Skaitlis nav masīvā");
            }

            // var arī šadi irAtrasts = masivs.Contains(skaitlis);
        }

        static void Uzdevums26()
        {
            int skaits = 5;
            int[] masivs = new int[skaits];

            for(int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine("Ievadi skaitļus: ");
                masivs[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = masivs.Length - 1; i >= 0; i--) // jo nav 5 pozīcija ir 4 pozicijas, tādēļ -1
            {
                Console.WriteLine(masivs[i]);
            }                        
        }

        static void pretejiSaraksts()
        {
            List<int> saraksts = new List<int>();


            while (true)
            {
                Console.WriteLine("Ievadi skaitļus (vai 0, lai pātrauktu): ");
                string vertiba = Console.ReadLine();
                if (String.IsNullOrEmpty(vertiba))  // ja ievada tukšumu tad pārtrauc
                {
                    break;
                }
                int skaitlis = Convert.ToInt32(vertiba);

                if(skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis);
            }

            /* vai arī
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ievadi skaitļus: ");
                saraksts.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int elementuSkaits = saraksts.Count;

            for (int i = saraksts.Count -1; i >= 0; i--)
            {
                Console.WriteLine(saraksts[i]);
            }

            saraksts.Reverse();
            Console.WriteLine(String.Join(",",saraksts));
            */
        }

        static void Uzdevums27()
        {
            List<int> saraksts = new List<int>();
            
            while (true)
            {
                Console.WriteLine("Ievadi skaitļus (vai 0, lai pātrauktu): ");
                string vertiba = Console.ReadLine();
                if (String.IsNullOrEmpty(vertiba)) 
                {
                    break;
                }
                int skaitlis = Convert.ToInt32(vertiba);

                if (skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis);       
            }

            int skaitlis5 = 0;
            foreach (int skaitlis in saraksts)
            {                
                    if (skaitlis == 5)
                    {
                        skaitlis5 += 1;
                    }                            
            }

            Console.WriteLine("Skaitlis 5 atrasts {0} reizes", skaitlis5);

            // 2.variants
            skaitlis5 = saraksts.Count(i => i == 5);
            Console.WriteLine("Skaitlis 5 atrasts {0} reizes", skaitlis5);
        }

        static void Uzdevums28()
        {
            List<int> saraksts = new List<int>();

            while (true)
            {
                Console.WriteLine("Ievadi skaitļus (vai 0, lai pātrauktu): ");
                string vertiba = Console.ReadLine();
                if (String.IsNullOrEmpty(vertiba))
                {
                    break;
                }
                int skaitlis = Convert.ToInt32(vertiba);

                if (skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis);
            }

            int max = saraksts.Max();
            int min = saraksts.Min();

            Console.WriteLine("Lielākais skaitlis ir {0}", max);
            Console.WriteLine("Māzākais skaitlis ir {0}", min);

        }

    }
}

