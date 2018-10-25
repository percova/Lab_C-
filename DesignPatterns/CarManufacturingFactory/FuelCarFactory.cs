namespace CarManufacturingFactory
{
    public class FuelCarFactory : CarFactory
    {
        public override PassengerCar CreatePassengerCar()
        {
            return new FuelCar();
        }

        public override Truck CreateTruck()
        {
            return new FuelTruck();
        }

        public override Bus CreateBus()
        {
            return new FuelBus();
        }
    }
}