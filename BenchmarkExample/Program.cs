using BenchmarkDotNet.Running;

namespace BenchmarkExample;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<DateParseBenchmarks>();
    }
}