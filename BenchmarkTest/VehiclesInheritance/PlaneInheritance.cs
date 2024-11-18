using BenchmarkTest.VirtualVehicleClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTest.VehiclesInheritance
{
    public class PlaneInheritance : Vehicle
    {
        public override void GetWheelsCount()
        {
            Console.WriteLine("Inherited plane has no wheels.");
        }
    }
}
