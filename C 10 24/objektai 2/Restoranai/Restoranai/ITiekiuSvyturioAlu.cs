using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranai
{
    public interface ITiekiuSvyturioAlu /*prie klases su daug daug properciu ir metodu, prijungia papildoma properti/metoda tamj kad nereiktu i objekta padfuoti visos dideles klases*/
    {
        public int SvyturioAlausLikutis { get; set; }
    }
}
