namespace CarManufacturingFactory
{
    public class Client
    {
        private PassengerCar _passengerCar;
        private Truck _truck;
        private Bus _bus;

        public Client(CarFactory factory)
        {
            _passengerCar = factory.CreatePassengerCar();
            _truck = factory.CreateTruck();
            _bus = factory.CreateBus();
        }
        
        public PassengerCar PassengerCar => _passengerCar;
        
        public Truck Truck => _truck;

        public Bus Bus => _bus;
    }
}