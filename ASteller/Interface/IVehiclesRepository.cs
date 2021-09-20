using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASteller.Data
{
    public interface IVehiclesRepository
    {
        List<T> GetByColor<T>(int color);
        bool ChangeCarHeadLightState(int carID, bool turnOn);
        bool Delete<T>(int ID);
    }
}
