using BenchmarkTest.VirtualVehicleClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTest.VehiclesInheritance
{
    public class CarInheritance : Vehicle
    {
        public override void GetWheelsCount()
        {
            Console.WriteLine("Inherited car has 4 wheels.");
        }
    }
}
