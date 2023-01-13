using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_Car_Test
{
    class SportsCar : Car
    {
        public SportsCar(float averageFuelConsumption, int fuelTankCapacity, int speed) 
        {
            carType = CarType.SportsCar;
            AverageFuelConsumption= averageFuelConsumption;
            FuelTankCapacity= fuelTankCapacity;
            Speed= speed;
        }
        public override float GetPowerReserveAtFullTankWithPassengersAndCargo()
            => GetPowerReserveAtFullTank();
        public override float GetPowerReserveAtTheMomentWithPassengersAndCargo(int carFuelQuantity)
            => GetPowerReserveAtTheMoment(carFuelQuantity);
        public override float GetTimeToCoverTheDistanceAtFullTank(int distance)
        {
            if (GetPowerReserveAtFullTank() < distance)
                throw new Exception("В автомобиле не хватает топлива!");
            return distance / Speed;
        }
        public override float GetTimeToCoverTheDistanceAtTheMoment(int distance, int carFuelQuantity)
        {
            if (GetPowerReserveAtTheMoment(carFuelQuantity) < distance)
                throw new Exception("В автомобиле не хватает топлива!");
            return distance / Speed;
        }
        public override float GetTimeToCoverTheDistanceAtFullTankWithPassengersAndCargo(int distance)
        {
            if (GetPowerReserveAtFullTankWithPassengersAndCargo() < distance)
                throw new Exception("В автомобиле не хватает топлива!");
            return distance / Speed;
        }
        public override float GetTimeToCoverTheDistanceAtTheMomentWithPassengersAndCargo(int distance, int carFuelQuantity)
        {
            if (GetPowerReserveAtTheMomentWithPassengersAndCargo(carFuelQuantity) < distance)
                throw new Exception("В автомобиле не хватает топлива!");
            return distance / Speed;
        }
    }
}
