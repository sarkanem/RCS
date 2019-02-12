using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    public class Karatavas
    {
        private string minamaisVards;
        private string[] atminetaisVards;
        private string[] vardnica =
        {
            "KROKODILS",
            "SALDUMS",
            "PROGRAMMA",
            "SVEICIENS",
            "STABURADZE"
        };

        public Karatavas()
        {

        }

        public void SaktSpeli()
        {
            // 1. Aizpilda minamaisVards ar izvēlēto vārdu
            Random rnd = new Random();
            int pozicija = rnd.Next(vardnica.Length); // šeit nav -1 jo Next atgriež par vienu mazāk
            minamaisVards = vardnica[pozicija];
            
            // 2. AtminetaisVards aizpilda ar '*', tik cik vārdā burtu

            atminetaisVards = new string[minamaisVards.Length];

            // cikls, kurš strādā minamaisVards.Length reizes un ieliek burtu pozīcijā *
            for (int i = 0; i < minamaisVards.Length; i++)
            {
                atminetaisVards[i] = "*";
            }
        }

        public bool IrAtminets()
        {
            // 1. Nosaka un atgriež, vai vārds ir pilnīgi atminēts
            // atgriež true / false vērtību

            // cikls, kurš strādā atminetaisVards.Length reizes
            // ja ir kāda * tad nav atminēts, jeb false

            foreach (string simbols in atminetaisVards) // vai  for (int i = 0; i < minamaisVards.Length; i++)
            {
                if (simbols == "*")
                {
                    return false;
                }
            }
            return true;

            /* vai arī
            
            return !atminetaisVards.Contains("*");  /// vai viss masīvs satur *
               
            */
        }

        public bool Minet(string burts)
        {
            // 1. Atgriež false, ja burts nav vārdā
            // 2. Atgriež true, ja burts ir vārdā. Aizvieto minamaisVards simbolu '*' ar burtu konkrētajā pozīcijā

            // minamaisVards.Contains
            // minamaisVards.IndexOf
            if (String.IsNullOrEmpty(burts))
            {
                return false;
            }

            burts = burts.ToUpper();

            if (!minamaisVards.Contains(burts))
            {
                return false;
            }
            
            int pozicija = minamaisVards.IndexOf(burts);
            while(pozicija != -1)
            {
                atminetaisVards[pozicija] = burts;
                pozicija = minamaisVards.IndexOf(burts, 1 + pozicija);
            }

            return true;
           
        }

        public string Vards()
        {
            // 1. Atgriež minamaisVards kā tekstu (string)

            string teksts = "";

            foreach (string zime in atminetaisVards) /// string vietā var likt var
            {
                teksts += zime;
            }
            return teksts;

            // vai arī return String.Join(" ", atminetaisVards);
        }
    }
}
