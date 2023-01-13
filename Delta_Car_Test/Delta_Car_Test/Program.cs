using Delta_Car_Test;

PassengerCar passengerCar = new PassengerCar(0.1f, 60, 60, 4);
passengerCar.NumberOfPassengeers = 2;
Console.WriteLine("Запас хода авто с полным баком и 2-мя пассажирами: " + passengerCar.GetPowerReserveAtFullTankWithPassengersAndCargo());

CargoCar cargoCar = new CargoCar(0.3f, 120, 30, 1600);
cargoCar.CargoWeight = 800;
Console.WriteLine("Запас хода авто с полным баком и грузом 800, при грузоподъемности в 1600: " + cargoCar.GetPowerReserveAtFullTankWithPassengersAndCargo());

SportsCar sportsCar = new SportsCar(0.2f, 60, 160);
Console.WriteLine("Запас хода спортивного авто с полным баком: " + sportsCar.GetPowerReserveAtFullTankWithPassengersAndCargo()); 
    
SportsCar sportsCar1 = new SportsCar(0.2f, 90, 90);
Console.WriteLine("За " + sportsCar1.GetTimeToCoverTheDistanceAtFullTank(450) + " час(ов) спортивный автомобиль пройдет 450км со скоростья 90");