namespace CarManufacturingFactory
{
    public abstract class CarFactory
    {
        public abstract PassengerCar CreatePassengerCar();
        public abstract Truck CreateTruck();
        public abstract Bus CreateBus();
    }
}