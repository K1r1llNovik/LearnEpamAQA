using System;
using System.Collections.Generic;


namespace OOP
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            /*try
             {
                 Car car = new Car(4,
                     new Chassis(4, "ASJSD", 400),
                     new Engine(165, 2.0, EngineType.Gasoline, "ASHD-2"),
                     new Transmission(TransmissionType.Automatic, 6, "Audi"));

                 Bus bus = new Bus(35,
                     new Chassis(6, "OPK-3", 5500),
                     new Engine(180, 5.5, EngineType.Diesel, "SWCH-34"),
                     new Transmission(TransmissionType.Manual, 6, "MAZ"));

                 Truck truck = new Truck(17000,
                     new Chassis(6, "SEWE-15", 7000),
                     new Engine(320, 8, EngineType.Gas, "EDFR-23"),
                     new Transmission(TransmissionType.Manual, 7, "BELAZ"));

                 Scooter scooter = new Scooter(2,
                     new Chassis(2, "13ABK", 150),
                     new Engine(50, 0.8, EngineType.Electrical, "QWERTY"),
                     new Transmission(TransmissionType.Automatic, 4, "YAMAHA"));

                 List<Vehicle> vehicles = new List<Vehicle>() { car, bus, truck, scooter };

                 CarPark carPark = new CarPark(vehicles);
                 carPark.Add(car);

                 Serializer<Vehicle>.Serialize("VehiclesWithEngineVolumeMoreThan.xml", Filtration.GetListOfVehiclesWithEngineVolumeMoreThan(1.5, vehicles));
                 Serializer<Engine>.Serialize("EngineInfoOfBusAndTruck.xml", Filtration.GetListOfEngineInfoOfBusAndTruck(vehicles));
                 Serializer<Vehicle>.Serialize("VehiclesGroupByTransmission.xml", Filtration.GetListOfVehiclesGroupByTransmission(vehicles));
             }
             catch (Exception exception)
             {
                 Console.WriteLine(exception.Message);
             }*/

            try
            {
                Car car = new Car(4,
                     new Chassis(4, "ASJSD", 400),
                     new Engine(165, 2.0, EngineType.Gasoline, "ASHD-2"),
                     new Transmission(TransmissionType.Automatic, 6, "Audi"));

                List<Vehicle> park = new List<Vehicle>() { car };

                CarPark carPark = new CarPark(park);
                carPark.Add(car);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
