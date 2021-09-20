using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ASteller.Data
{
    public class Car : Vehicle
    {
        public Car()
        {
            this.Wheels = new Wheels();
            this.HeadLights = new HeadLights();
            _type = EnumVehicleType.car;

        }
        public Wheels Wheels { get; set; }
        public HeadLights HeadLights { get; set; }
    }
}
