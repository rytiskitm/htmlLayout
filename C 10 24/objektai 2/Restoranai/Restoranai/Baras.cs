using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranai
{
    public class Baras : MaitinimoIstaiga, ITiekiuSvyturioAlu
    {
        public int MustyniuSkaicius { get; set; }
        public int SvyturioAlausLikutis { get; set; }

        public override bool ArBuvoMustyniu()/*sitoj vietoj panaudojau tevinej klasej deklaruota metoda*/
        {
            return this.MustyniuSkaicius > 0;/*grazina true*/
        }

    }
}
