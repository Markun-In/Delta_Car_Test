using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_Car_Test
{
    class CargoCar : Car
    {
        private int cargoWeight; // Вес груза
        public int LoadCapacity { get; set; } // Грузоподъемность машины
        public int CargoWeight 
        {
            get => cargoWeight;
            set
            {
                if (value > LoadCapacity)
                    throw new Exception("Вес груза превышает грузоподъемность автомобиля!");
                cargoWeight = value;
            }
        }
        public CargoCar(float averageFuelConsumption, int fuelTankCapacity, int speed, int loadCapacity)
        {
            carType = CarType.CargoCar;
            AverageFuelConsumption= averageFuelConsumption;
            FuelTankCapacity= fuelTankCapacity;
            Speed= speed;
            LoadCapacity= loadCapacity;
        }
        public override float GetPowerReserveAtFullTankWithPassengersAndCargo()
            => (FuelTankCapacity / AverageFuelConsumption) - (FuelTankCapacity * 0.04f * (cargoWeight / 200) / AverageFuelConsumption);
        public override float GetPowerReserveAtTheMomentWithPassengersAndCargo(int carFuelQuantity)
            => (carFuelQuantity / AverageFuelConsumption) - (carFuelQuantity * 0.04f * (cargoWeight / 200) / AverageFuelConsumption);
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
