using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASteller.Data
{
    /// <summary>
    /// This repository used for Car, Buse, Boat vehicles
    /// </summary>
    public class VehiclesRepository : IVehiclesRepository
    {
        /// <summary>
        /// Change car headlights state
        /// </summary>
        /// <param name="carID">Car ID</param>
        /// <param name="turnOn">True:On, False: Off</param>
        /// <returns>True: Changed, False: Car Not Found</returns>
        public bool ChangeCarHeadLightState(int carID, bool turnOn)
        {
            Vehicle item = VehicleDatabase.VehicleSet.FirstOrDefault(x => x.ID == carID && x.Type == EnumVehicleType.car);

            if (item != null)
            {
                Car found = item as Car;
                if (turnOn)
                    found.HeadLights.State = EnumHeadLightState.On;
                else
                    found.HeadLights.State = EnumHeadLightState.Off;
            }

            return (item != null);
        }

        /// <summary>
        /// Delete Vehicles By ID
        /// </summary>
        /// <typeparam name="T">Vehicle Class</typeparam>
        /// <param name="ID">Vehicle ID</param>
        /// <returns>True: Deleted, False: Vehicle Not Found</returns>
        public bool Delete<T>(int ID)
        {
            EnumVehicleType vehicleType = GetVehicleType<T>();
            Vehicle item = VehicleDatabase.VehicleSet.FirstOrDefault(x => x.ID == ID && x.Type == vehicleType);

            if (item != null)
                item.Delete();

            return (item != null);
        }

        /// <summary>
        /// Get vehicle list by color 
        /// </summary>
        /// <typeparam name="T">Vehicle Class</typeparam>
        /// <param name="color">color (EnumColor is used, so color values must be EnumColor range)</param>
        /// <returns>Vehicles</returns>
        public List<T> GetByColor<T>(int color)
        {
            EnumColor vehicleColor = (EnumColor)color;
            EnumVehicleType vehicleType = GetVehicleType<T>();

            return VehicleDatabase.VehicleSet.Where(x => x.Color == vehicleColor && (x.Type == vehicleType || vehicleType == EnumVehicleType.none)).Cast<T>().ToList();
        }

        private EnumVehicleType GetVehicleType<T>()
        {
            Type vehicleType = typeof(T);
            if (vehicleType == typeof(Car))
                return EnumVehicleType.car;
            else if (vehicleType == typeof(Buse))
                return EnumVehicleType.buse;
            else if (vehicleType == typeof(Boat))
                return EnumVehicleType.boat;
            else
                return EnumVehicleType.none;

        }
    }
}
