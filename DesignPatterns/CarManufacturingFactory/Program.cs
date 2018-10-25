using System;

namespace CarManufacturingFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CarFactory elFac = new ElectricCarFactory();
            Client electric = new Client(elFac);
            Console.WriteLine(electric.PassengerCar.GetType());
            Console.WriteLine(electric.Truck.GetType());
            Console.WriteLine(electric.Bus.GetType());
 
            CarFactory fuelFac = new FuelCarFactory();
            Client fuel = new Client(fuelFac);
            Console.WriteLine(fuel.PassengerCar.GetType());
            Console.WriteLine(fuel.Truck.GetType());
            Console.WriteLine(fuel.Bus.GetType());
        }
    }
}