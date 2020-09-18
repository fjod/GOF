using System;
using System.Collections.Generic;

namespace GOF.Behavioral.Visitor.ZoranHorvat
{
    public class VisitorImpl : IPatternTest
    {
        public void Implement()
        {
            IEnumerable<Car> cars = new CarRepository().GetAll();

            Client view = new Client(cars);
            view.Render();
            view.GetOnlyParts();
        }

        public void Name()
        {
            Console.WriteLine("====Visitor ZH====");
        }
    }
}