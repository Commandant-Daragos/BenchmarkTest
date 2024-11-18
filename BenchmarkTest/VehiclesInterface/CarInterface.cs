using BenchmarkTest.Interfaces;

namespace BenchmarkTest.VehiclesInterface
{
    public class CarInterface : ICar
    {
        public void GetWheelsCount()
        {
            Console.WriteLine("Interface car has 4 wheels.");
        }
    }
}
