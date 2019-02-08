using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            skaitluIevade();
            Console.WriteLine(); // lai būtu atstarpe starp uzdevumiem
            graduKonvertacija();
            Console.WriteLine();
            videjaVertiba();
            Console.Read();
        }
        static void skaitluIevade()
        {
            Console.Write("Ievadi pirmo skaitli: ");
           
            int pirmais = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi otro skaitli: ");

            int otrais = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaitļu summa ir " + (pirmais + otrais)); // var arī pirms tam definēt int summa = pirmais + otrais un tad pieskaitīt summa
            Console.WriteLine("Skaitļu starpība ir " + (pirmais - otrais));
            Console.WriteLine("Skaitļu reizinājums ir " + (pirmais * otrais));
            Console.WriteLine("Skaitļu dalījums ir " + (pirmais / (float)otrais)); // lai būtu decimāldaļas, kad dala liek float data tipu var arī agrāk - jau definējot pirmais/otrais to likt
    
        }

        static void graduKonvertacija()
        {
            Console.Write("Ievadi temperatūru pēc Celsija (ºC): ");

            float tempC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Grādi pēc Kelvina ir " + (tempC + 273.15 + " K"));
            Console.WriteLine("Grādi pēc Fārenheita ir " + (tempC * 9/5 + 32 + " ºF"));


        }

        static void videjaVertiba()
        {
            Console.WriteLine("Ievadi četrus skaitļus: ");

            float sk1 = Convert.ToInt32(Console.ReadLine());
            float sk2 = Convert.ToInt32(Console.ReadLine());
            float sk3 = Convert.ToInt32(Console.ReadLine());
            float sk4 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Vidējā vērtība ir " + ((sk1 + sk2 + sk3 + sk4) / 4));
         }
    }
}
