using System;

namespace CarManufacturingFactory
{
    public abstract class PassengerCar
    {
        public abstract void Ride();
    }

    public class ElectricCar : PassengerCar
    {
        public override void Ride()
        {
            Console.WriteLine("Moving on electricity");
        }
        
    }

    public class FuelCar : PassengerCar
    {
        public override void Ride()
        {
            Console.WriteLine("Moving on fuel");
        }
    }
}