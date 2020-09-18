using System.Collections.Generic;

namespace GOF.Behavioral.Visitor.ZoranHorvat
{
    /// <summary>
    /// cant not be changed, let's pretend it's outside of our reach
    /// </summary>
    public class Seat
    {
        public readonly string name;
        public readonly int capacity;

        public Seat(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        public static IEnumerable<Seat> FourSeatConfiguration
        {
            get
            {
                return new Seat[]
                {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1),
                    new Seat("Rear bench", 2)
                };
            }
        }

        public static IEnumerable<Seat> TwoSeatConfiguration
        {
            get
            {
                return new Seat[]
                {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1)
                };
            }
        }
    }
}