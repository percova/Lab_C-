using System;

namespace CarManufacturingFactory
{
    public abstract class Truck
    {
        public abstract void GoodsTransport();
    }

    public class ElectricTruck : Truck
    {
        public override void GoodsTransport()
        {
            Console.WriteLine("Goods transportation on electricity");
        }
    }

    public class FuelTruck : Truck
    {
        public override void GoodsTransport()
        {
            Console.WriteLine("Goods transportation on fuel");
        }
    }
}