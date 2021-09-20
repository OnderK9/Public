using ASteller.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ASteller.Data
{
    public class Vehicle : IVehicle
    {
        protected EnumVehicleType _type = EnumVehicleType.none;
        private EnumEntityState _state = EnumEntityState.none;
        public Vehicle()
        {
            this.Color = EnumColor.white;
            _state = EnumEntityState.added;
        }
        public EnumColor Color { get; set; }

        public EnumVehicleType Type { get { return _type; } }
        public EnumEntityState State { get { return _state; } }

        public int ID { get; set; }

        public void Delete()
        {
            _state = EnumEntityState.deleted;
        }
    }
}
