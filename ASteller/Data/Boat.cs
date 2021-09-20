using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ASteller.Data
{
    public class Boat:Vehicle
    {
        public Boat()
        {
            _type = EnumVehicleType.boat;
        }
    }
}
