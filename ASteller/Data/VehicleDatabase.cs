using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASteller.Data
{
    public class VehicleDatabase
    {
        private static List<Vehicle> _VehicleSet = null;
        public static List<Vehicle> VehicleSet
        {
            get
            {
                if (_VehicleSet == null)
                {
                    _VehicleSet = new List<Vehicle>();
                    AddCars(_VehicleSet);
                    AddBuses(_VehicleSet);
                    AddBoats(_VehicleSet);
                }
                return _VehicleSet;
            }
        }

        private static void AddCars(List<Vehicle> list)
        {

            Car car = new Car();
            car.Color = EnumColor.black;
            car.ID = 1;
            list.Add(car);

            car = new Car();
            car.Color = EnumColor.black;
            car.ID = 2;
            list.Add(car);

            car = new Car();
            car.Color = EnumColor.black;
            car.ID = 3;
            list.Add(car);

            car = new Car();
            car.Color = EnumColor.blue;
            car.ID = 4;
            list.Add(car);

            car = new Car();
            car.Color = EnumColor.white;
            car.ID = 5;
            list.Add(car);

            car = new Car();
            car.Color = EnumColor.white;
            car.ID = 6;
            list.Add(car);

        }

        private static void AddBuses(List<Vehicle> list)
        {

            Buse buse = new Buse();
            buse.Color = EnumColor.red;
            buse.ID = 1;
            list.Add(buse);

            buse = new Buse();
            buse.Color = EnumColor.black;
            buse.ID = 2;
            list.Add(buse);

            buse = new Buse();
            buse.Color = EnumColor.blue;
            buse.ID = 3;
            list.Add(buse);

            buse = new Buse();
            buse.Color = EnumColor.blue;
            buse.ID = 4;
            list.Add(buse);

            buse = new Buse();
            buse.Color = EnumColor.white;
            buse.ID = 5;
            list.Add(buse);

            buse = new Buse();
            buse.Color = EnumColor.white;
            buse.ID = 6;
            list.Add(buse);

        }

        private static void AddBoats(List<Vehicle> list)
        {

            Boat boat = new Boat();
            boat.Color = EnumColor.red;
            boat.ID = 1;
            list.Add(boat);

            boat = new Boat();
            boat.Color = EnumColor.black;
            boat.ID = 2;
            list.Add(boat);

            boat = new Boat();
            boat.Color = EnumColor.blue;
            boat.ID = 3;
            list.Add(boat);

            boat = new Boat();
            boat.Color = EnumColor.blue;
            boat.ID = 4;
            list.Add(boat);

            boat = new Boat();
            boat.Color = EnumColor.red;
            boat.ID = 5;
            list.Add(boat);

            boat = new Boat();
            boat.Color = EnumColor.red;
            boat.ID = 6;
            list.Add(boat);
        }

    }
}
