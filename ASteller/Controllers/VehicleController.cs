using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASteller.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASteller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        IVehiclesRepository repository = null;
        public VehicleController(IVehiclesRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<IEnumerable<Vehicle>> GetVehiclesByColor(int type, int color)
        {
            EnumVehicleType vehicleType = (EnumVehicleType)type;
            List<Vehicle> vehicles = new List<Vehicle>();
            switch (vehicleType)
            {
                case EnumVehicleType.car:
                    vehicles = this.repository.GetByColor<Car>(color).ToList<Vehicle>();
                    break;
                case EnumVehicleType.buse:
                    vehicles = this.repository.GetByColor<Buse>(color).ToList<Vehicle>();
                    break;
                case EnumVehicleType.boat:
                    vehicles = this.repository.GetByColor<Buse>(color).ToList<Vehicle>();
                    break;
                case EnumVehicleType.none:
                    vehicles = this.repository.GetByColor<Vehicle>(color);
                    break;
                default:
                    break;
            }

            return vehicles;
        }

        [HttpGet]
        [Route("car")]
        public ActionResult<IEnumerable<Car>> GetCarsByColor(int color)
        {
            List<Car> cars = this.repository.GetByColor<Car>(color);
            return cars;
        }

        [HttpGet]
        [Route("buse")]
        public ActionResult<IEnumerable<Buse>> GetBusesByColor(int color)
        {
            List<Buse> buses = this.repository.GetByColor<Buse>(color);
            return buses;
        }

        [HttpGet]
        [Route("boat")]
        public ActionResult<IEnumerable<Boat>> GetBoatsByColor(int color)
        {
            List<Boat> boats = this.repository.GetByColor<Boat>(color);
            return boats;
        }

        [Route("car")]
        [HttpPost]
        public bool Post(int carID, bool turnOn)
        {
            return this.repository.ChangeCarHeadLightState(carID, turnOn);
        }

        [Route("car")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return this.repository.Delete<Car>(id);
        }
    }
}
