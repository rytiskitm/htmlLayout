using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranai
{
    public abstract class MaitinimoIstaiga /*jei klase yra abstrakti tai jai NEGALIMA sukurti objekto, o tik ja paveldeti*/
    {
        public int SedimuVietuSkaicius { get; set; }
        public int StaliukuSkaicius { get; set; }
        public int PadavejuSkaicius { get; set; }
        public string[] MeniuIrasai { get; set; }
        public string[] Gerimai { get; set; }

        public void Gerti()
        {
            Console.WriteLine("Zmones geria alkocholi");
        }
        public bool ArGalimaPavalgyti()
        {
            if (this.MeniuIrasai.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ArGalimaIsgerti()
        {
            if (this.MeniuIrasai.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public abstract bool ArBuvoMustyniu(); /*abstraktu metoda privales ivykdyt vaikines klases kuris paveldi sita klase*/
    }
}
