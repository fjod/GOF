namespace GOF.Behavioral.Visitor.ZoranHorvat
{
    static class ExtensionForInterfaces
    {
        public static void Accept(this Car car, ICarVisitor visitor)
        {
            car.engine.Accept(visitor);
            foreach (Seat seat in car.seats)
                seat.Accept(visitor);
           // visitor.VisitCar(car.make, car.model);
           visitor.Visit(car);
        }
        
        static void Accept(this Engine engine, ICarPartVisitor visitor)
        {
           // visitor.VisitEngine(engine.power, engine.cylinderVolume, engine.temperatureC);
           visitor.Visit(engine);
        }
        
        static void Accept(this Seat seat, ICarPartVisitor visitor)
        {
         //   visitor.VisitSeat(seat.name, seat.capacity);
         visitor.Visit(seat);
        }
    }
}