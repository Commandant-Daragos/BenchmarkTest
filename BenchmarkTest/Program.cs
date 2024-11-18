using BenchmarkDotNet.Running;

namespace BenchmarkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkTestClass>();
        }
    }
}
