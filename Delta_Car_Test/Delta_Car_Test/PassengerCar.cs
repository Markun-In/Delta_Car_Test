using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_Car_Test
{
    class PassengerCar : Car
    {
        private int numberOfPassengeers;
        public int NumberOfSeatsForPassengers { get; set; } // Кол-во мест для пассажиров в автомобиле
        public int NumberOfPassengeers // Кол-во пассадиров
        {
            get => numberOfPassengeers;
            set
            {
                if (value > NumberOfSeatsForPassengers)
                    throw new Exception("Пассажиров больше, чем мест в автомобиле!");
                 numberOfPassengeers = value ;
            }
        }
        public PassengerCar(float averageFuelConsumption, int fuelTankCapacity, int speed, int numberOfSeatsForPassengers)
        {
            carType = CarType.PassengerCar;
            AverageFuelConsumption= averageFuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            Speed = speed;
            NumberOfSeatsForPassengers= numberOfSeatsForPassengers;
        }
        public override float GetPowerReserveAtFullTankWithPassengersAndCargo()
            => (FuelTankCapacity / AverageFuelConsumption) - (FuelTankCapacity * 0.06f * numberOfPassengeers / AverageFuelConsumption);
        public override float GetPowerReserveAtTheMomentWithPassengersAndCargo(int carFuelQuantity)
            => (carFuelQuantity / AverageFuelConsumption) - (carFuelQuantity * 0.06f * numberOfPassengeers / AverageFuelConsumption);
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
