using BenchmarkTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTest.VirtualVehicleClass
{
    public abstract class Vehicle : IVehicle
    {
        //virtual method for wheels-needed override
        public virtual void GetWheelsCount()
        {
            Console.WriteLine("This vehicle has unidentified number of wheels.");
        }

        //abstract method-must be implemented by derived class
        //public abstract string GetAbstractWheelCount();
    }
}
