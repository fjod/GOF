namespace GOF.Behavioral.Visitor.ZoranHorvat
{
    public class CarToStringVisitor:ICarVisitor
    {
        private string carDetails;
        private string engineDetails;
        private int seatsCount;
        
        public void VisitEngine(float power, float cylinderVolume, float temperatureC)
        {
            this.engineDetails = string.Format("{0}cc {1}kW", cylinderVolume, power);
        }

        public void VisitSeat(string name, int capacity)
        {
            this.seatsCount += capacity;
        }

        public void VisitCar(string make, string model)
        {
            this.carDetails = string.Format("{0} {1}", make, model);
        }
        
        public string GetCarDescription()
        {
            return string.Format("{0} {1} {2} seat(s)",
                this.carDetails, this.engineDetails,
                this.seatsCount);
        }

        public void Visit(Engine engine)
        {
            VisitEngine(engine.power,engine.cylinderVolume, engine.temperatureC);
        }

        public void Visit(Seat seat)
        {
            VisitSeat(seat.name, seat.capacity);
        }

        public void Visit(Car car)
        {
            VisitCar(car.make, car.model);
        }
    }
}