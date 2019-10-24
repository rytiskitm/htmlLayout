using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranai
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            Kavine geraKava = new Kavine();
            geraKava.Gerimai = new string[] { "Kava", "Late", "Machito" };
            if (geraKava.ArGalimaIsgerti())
            {
                Console.WriteLine("Geriam kava");
            }
            else
            {
                Console.WriteLine("Ner kavos");
            }
            */
            //Console.ReadKey();


            Baras bozke = new Baras();
            bozke.SvyturioAlausLikutis = 12;

            Baras republic = new Baras();
            republic.SvyturioAlausLikutis = 214;

            republic.SvyturioAlausLikutis -= 80;






        }
    }
}
