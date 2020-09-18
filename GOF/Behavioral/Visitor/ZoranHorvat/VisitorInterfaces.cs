namespace GOF.Behavioral.Visitor.ZoranHorvat
{
    interface ICarPartVisitor
    {
        // void VisitEngine(float power, float cylinderVolume, float temperatureC);
        //  void VisitSeat(string name, int capacity);
        void Visit(Engine engine);
        void Visit(Seat seat);
    }

    interface ICarVisitor : ICarPartVisitor
    {
        //       void VisitCar(string make, string model);
        void Visit(Car car);
    }
}