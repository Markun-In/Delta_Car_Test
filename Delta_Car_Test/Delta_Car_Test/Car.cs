using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_Car_Test
{
    abstract class Car
    {
        private protected enum CarType
        {
            PassengerCar,
            CargoCar,
            SportsCar
        }

        private protected CarType carType;
        public float AverageFuelConsumption { get; set; } // Средний расход топлива автомобилем
        public int FuelTankCapacity { get; set; } // Объем топливного бака автомобиля
        public int Speed { get; set; } // Скорость автомобиля

        /// <summary>
        /// Метод, возвращающий запас хода авто с полным баком (без учета груза и кол-ва пассажиров)
        /// </summary>
        public float GetPowerReserveAtFullTank()
            => FuelTankCapacity / AverageFuelConsumption;
        /// <summary>
        /// Метод, возвращающий запас хода авто с заданным кол-вом топлива в баке (без учета груза и кол-ва пассажиров)
        /// </summary>
        public float GetPowerReserveAtTheMoment(int carFuelQuantity)
            => carFuelQuantity / AverageFuelConsumption;
        /// <summary>
        /// Метод, возвращающий запас хода авто с полным баком (с учетом груза и кол-ва пассажиров)
        /// </summary>
        public abstract float GetPowerReserveAtFullTankWithPassengersAndCargo();
        /// <summary>
        /// Метод, возвращающий запас хода авто с заданным кол-вом топлива в баке (с учетом груза и кол-ва пассажиров)
        /// </summary>
        public abstract float GetPowerReserveAtTheMomentWithPassengersAndCargo(int carFuelQuantity);
        /// <summary>
        /// Метод, возвращающий время в часах, за которое автомобиль проедет заданное расстояние с полным баком (без учета груза)
        /// </summary>
        public abstract float GetTimeToCoverTheDistanceAtFullTank(int distance);
        /// <summary>
        /// Метод, возвращающий время в часах, за которое автомобиль проедет заданное расстояние
        /// с заданным кол-вом топлива в баке (без учета груза)
        /// </summary>
        public abstract float GetTimeToCoverTheDistanceAtTheMoment(int distance, int carFuelQuantity);
        /// <summary>
        /// Метод, возвращающий время в часах, за которое автомобиль проедет заданное расстояние с полным баком (с учетом груза)
        /// </summary>
        public abstract float GetTimeToCoverTheDistanceAtFullTankWithPassengersAndCargo(int distance);
        /// <summary>
        /// Метод, возвращающий время в часах, за которое автомобиль проедет заданное расстояние 
        /// с заданным кол-вом топлива в баке (с учетом груза)
        /// </summary>
        public abstract float GetTimeToCoverTheDistanceAtTheMomentWithPassengersAndCargo(int distance, int carFuelQuantity);

    }
}
