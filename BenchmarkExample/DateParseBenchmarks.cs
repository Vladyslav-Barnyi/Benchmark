using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkExample;
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateParseBenchmarks
{
    private const string DateTime = "2019-12-13T16:33:06Z";
    private static readonly DataParser Parser = new DataParser();

    [Benchmark(Baseline = true)]
    public void GetYearFromDateTime()
    {
        Parser.GetYearFromDateTime(DateTime);
    }
    
    [Benchmark]
    public void GetYearFromSplit()
    {
        Parser.GetYearFromSplit(DateTime);
    }
        
    [Benchmark]
    public void GetYearFromSubstring()
    {
        Parser.GetYearFromSubstring(DateTime);
    }
        
    [Benchmark]
    public void GetYearFromSpan()
    {
        Parser.GetYearFromSpan(DateTime);
    }
    
    [Benchmark]
    public void GetYearFromSpanWithManualConversionFor()
    {
        Parser.GetYearFromSpanWithManualConversionFor(DateTime);
    }
    
    [Benchmark]
    public void GetYearFromSpanWithManualConversionForeach()
    {
        Parser.GetYearFromSpanWithManualConversionForeach(DateTime);
    }
}