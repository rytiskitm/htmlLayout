using Loginas.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginas
{

    public class Vartotojas
    {
        public Vartotojas(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            this.VartotojoPrisijungimoDuomenys = new PrisijungimoDuomenys();
        }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        public PrisijungimoDuomenys VartotojoPrisijungimoDuomenys { get; set; }
    }
}
