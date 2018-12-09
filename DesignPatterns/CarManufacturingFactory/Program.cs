using System;

namespace CarManufacturingFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CarFactory elFac = new ElectricCarFactory();
            Client electric = new Client(elFac);
            electric.Ride();
            electric.PassangerTransport();
            electric.GoodsTransport();
            
            CarFactory fuelFac = new FuelCarFactory();
            Client fuel = new Client(fuelFac);
            fuel.Ride();
            fuel.PassangerTransport();
            fuel.GoodsTransport();
        }
    }
}