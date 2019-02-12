using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9
{
    class Program
    {
        static void Main(string[] args)
        {

            Taisnsturis t1 = new Taisnsturis(10.5, 20);
            Aprekini(t1);

            try
            {
                Console.WriteLine("Ievadi apļa radiusu: ");
                double r = double.Parse(Console.ReadLine());

                Aplis a1 = new Aplis(r);
                Aprekini(a1);
            }
            catch (FormatException) // norāda kuras klūdas gribam ķert
            {
                Console.WriteLine("Ievadīta nekorekta vērtība!");
            }
            catch (Exception ex) // parāda pārējās kļūdas
            {
                Console.WriteLine("Notika neparedzēta kļūda!");
                Console.WriteLine(ex.Message); // parrādīs kāda kļūda, bet šo lietotājiem labāk nerādīt
            }            

            Kvadrats k1 = new Kvadrats(12);
            Aprekini(k1);

            Console.ReadLine();
        }
            
        static void Aprekini(IGeometriskaFigura f)
        {
            Console.WriteLine("{1} laukums = {0}", f.Laukums(), f.Nosaukums());
            Console.WriteLine("{1} perimetrs = {0}", f.Perimetrs(), f.Nosaukums());

            /* vai arī
            string nosaukums = "";
            if (f is Taisnsturis)
            {
                nosaukums = "Taisnstūra";
            }
            else if (f is Aplis)
            {
                nosaukums = "Apļa";
            }

            Console.WriteLine("{1} laukums = {0}", f.Laukums(), nosaukums);
            Console.WriteLine("{1} perimetrs = {0}", f.Perimetrs(), nosaukums);
            */
        }
    }
}
