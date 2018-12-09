using System;

namespace CarManufacturingFactory
{
    public abstract class Bus
    {
        public abstract void PassengerTransport();
    }

    public class ElectricBus : Bus
    {
        public override void PassengerTransport()
        {
            Console.WriteLine("Passenger transportation on electricity");
        }
    }

    public class FuelBus : Bus
    {
        public override void PassengerTransport()
        {
            Console.WriteLine("Passenger transportation on fuel");
        }
    }
}