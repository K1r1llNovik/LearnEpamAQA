using System;

namespace OOP
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Car Car = new Car(4,
                new Chassis(4, "SKFNR", 500),
                new Engine(165, 3.5, EngineType.Gasoline, "ASDEFGF"),
                new Transmission(TransmissionType.Manual, 6, "ZF"));

            Console.WriteLine(Car.GetInfo());
        }
    }
}
