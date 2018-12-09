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

        public void Ride()
        {
            _passengerCar.Ride();
        }

        public void PassangerTransport()
        {
            _bus.PassengerTransport();
        }

        public void GoodsTransport()
        {
            _truck.GoodsTransport();
        }
    }
}