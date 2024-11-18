using BenchmarkDotNet.Attributes;
using BenchmarkTest.Interfaces;
using BenchmarkTest.VehiclesInheritance;
using BenchmarkTest.VehiclesInterface;
using BenchmarkTest.VirtualVehicleClass;

namespace BenchmarkTest
{
    [MemoryDiagnoser]
    public class BenchmarkTestClass
    {
        private const int MAXRANGE = 1_000_001; //1_000_001 representing 1000001 iterations, one more is because max range takes number thats 1 less
        [Benchmark]
        public void ListAllVehicleInfoInheritance()
        {
            var bicycle = new BicycleInheritance();
            var car = new CarInheritance();
            var plane = new PlaneInheritance();

            List<Vehicle> vehicles = new List<Vehicle> { bicycle, car, plane };
            Enumerable.Range(0, MAXRANGE).ToList().ForEach(_ =>
            {
                foreach (var vehicle in vehicles)
                {
                    vehicle.GetWheelsCount();
                }
            });
        }

        [Benchmark]
        public void ListAllVehicleInfoInterface()
        {
            var bicycle = new BicycleInterface();
            var car = new CarInterface();
            var plane = new PlaneInterface();

            List<IVehicle> vehicles = new List<IVehicle> { bicycle, car, plane };
            Enumerable.Range(0, MAXRANGE).ToList().ForEach(_ =>
            {
                foreach (var vehicle in vehicles)
                {
                    vehicle.GetWheelsCount();
                }
            });

            //bicycle.GetWheelsCount();
            //car.GetWheelsCount();
            //plane.GetWheelsCount();
        }
    }
}
