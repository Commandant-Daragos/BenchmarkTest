using BenchmarkTest.Interfaces;

namespace BenchmarkTest.VehiclesInterface
{
    public class BicycleInterface : IBicycle
    {
        public void GetWheelsCount() 
        {
            Console.WriteLine("Interface bicycle has 2 wheels.");
        }
    }
}
