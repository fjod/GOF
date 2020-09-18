using System;

namespace GOF.Behavioral.Visitor.ZoranHorvat
{
    /// <summary>
    /// cant not be changed, let's pretend it's outside of our reach
    /// </summary>
    public class Engine
    {
        public readonly float power;
        public readonly float cylinderVolume;

        private const float WorkingTemperatureC = 90.0F;
        public float temperatureC { get; private set; }= 20.0F;

        public Engine(float power, float cylinderVolume)
        {
            this.power = power;
            this.cylinderVolume = cylinderVolume;
        }

        public void Run(TimeSpan time)
        {
            TimeSpan heatingTime = GetHeatingTime();

            if (time > heatingTime)
            {
                this.temperatureC = WorkingTemperatureC;
            }
            else
            {
                double temperatureDelta = WorkingTemperatureC - this.temperatureC;
                double timeRatio = time.TotalMinutes / heatingTime.TotalMinutes;
                this.temperatureC += (float) (temperatureDelta * timeRatio);
            }
        }

        private TimeSpan GetHeatingTime()
        {
            double meanPower = 180.0;
            double nominalHeatingTimeSec = 300.0;

            int seconds = (int) (nominalHeatingTimeSec * meanPower / this.power);

            return new TimeSpan(0, 0, seconds);
        }
    }
}