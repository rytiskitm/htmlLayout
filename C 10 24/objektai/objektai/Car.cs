using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektai
{
    class abstract class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }
        public int WheelCount { get; set; }

        public abstract void Drive();

        public abstract void Stop();

        public abstract void Turn();



    }
}
