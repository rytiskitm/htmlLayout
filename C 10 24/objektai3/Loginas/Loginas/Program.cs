using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginas
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Vartotojas vartotojas1 = new Vartotojas("Joinas", "Ponas");


            //vartotojas1.Vardas = "Jonas";
           // vartotojas1.Pavarde = "Ponas";
          //  vartotojas1.VartotojoPrisijungimoDuomenys = new model.PrisijungimoDuomenys();

            vartotojas1.VartotojoPrisijungimoDuomenys.PrisijungimoVardas = "jon";

            Console.WriteLine(vartotojas1.VartotojoPrisijungimoDuomenys.PrisijungimoVardas);

        }
    }
}
