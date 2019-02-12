using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Program
    {
        static void Main(string[] args)
        {
            Karatavas spele = new Karatavas();              

            while (true) // šo atkārto līdz atbilst tam nosacījumam, ka nē
            { 
                spele.SaktSpeli();
                Console.WriteLine(spele.Vards());

                while (!spele.IrAtminets())
                {
                    Console.WriteLine("\nIevadi burtu: ");
                    string burts = Console.ReadLine();

                    if (spele.Minet(burts))
                    {
                        Console.WriteLine(spele.Vards());
                    }

                    else
                    {
                        Console.WriteLine("Burts nav šajā vārdā!");
                    }
                }

                Console.Write("\nApsveicu! Vārds ir atminēts!");

                Console.Write("\nVai Tu vēlies spēlēt vēlreiz? (J/N)");
                string atbilde = Console.ReadLine().ToUpper();

                if (atbilde == "N")
                {
                    Console.Write("\nPaldies par spēli!");
                    break;
                }                
            }
            Console.ReadLine();
        }
    }
}
