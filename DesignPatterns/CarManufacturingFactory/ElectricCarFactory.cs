namespace CarManufacturingFactory
{
    public class ElectricCarFactory : CarFactory
    {
        public override PassengerCar CreatePassengerCar()
        {
            return new ElectricCar();
        }

        public override Truck CreateTruck()
        {
            return new ElectricTruck();
        }

        public override Bus CreateBus()
        {
            return new ElectricBus();
        }
    }
}