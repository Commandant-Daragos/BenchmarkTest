using BenchmarkTest.Interfaces;

namespace BenchmarkTest.VehiclesInterface
{
    public class PlaneInterface : IPlane
    {
        public void GetWheelsCount()
        {
            Console.WriteLine("Interface plane has no wheels.");
        }
    }
}
