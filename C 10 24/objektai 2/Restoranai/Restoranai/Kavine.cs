using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoranai
{
    public class Kavine : MaitinimoIstaiga
    {
        public int GeruPadavejuSkaicius { get; set; }

        public override bool ArBuvoMustyniu()
        {
            throw new NotImplementedException();
        }
    }
}
