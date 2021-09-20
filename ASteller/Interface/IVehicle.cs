using ASteller.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ASteller.Interface
{
    public interface IVehicle
    {
        EnumColor Color { get; set; }
        EnumVehicleType Type { get; }
        int ID { get; set; }

        EnumEntityState State { get; }
        void Delete();
    }
}
