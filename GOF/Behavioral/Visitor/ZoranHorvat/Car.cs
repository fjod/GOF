using System.Collections.Generic;
using System.Linq;

namespace GOF.Behavioral.Visitor.ZoranHorvat
{
    public class Car
    {
        public readonly string make;
        public readonly string model;
        public readonly Engine engine;
        public readonly IEnumerable<Seat> seats;

        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            this.make = make;
            this.model = model;
            this.engine = engine;
            this.seats = new List<Seat>(seats);
        }

        public CarRegistration Register()
        {
            // return new CarRegistration(this.make.ToUpper(), this.model,
            //                            this.engine.cylinderVolume,
            //                            this.seats.Sum(seat => seat.capacity));
            return null;
        }
    }
}