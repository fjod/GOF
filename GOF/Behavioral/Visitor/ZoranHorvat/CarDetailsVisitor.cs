namespace GOF.Behavioral.Visitor.ZoranHorvat
{
    public class CarDetailsVisitor : ICarVisitor
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
            //here we are not interested in this
        }
        
        public string GetCarDescription()
        {
            return string.Format("{0} {1}  seat(s)",
                this.seatsCount, this.engineDetails);
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