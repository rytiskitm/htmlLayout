using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranai
{
    class Valgykla : MaitinimoIstaiga
    {
        public bool ArYraTarakonu { get; set; }

        public override bool ArBuvoMustyniu()
        {
            throw new NotImplementedException();
        }
    }
}
