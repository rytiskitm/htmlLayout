using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektai
{
    class Truck : Car
    {
        public int PullingWeight { get; set; }

        public abstract void Pull()
        {

        }
        public abstract void DropTrailer()
        {

        }
    }
}
