```

BenchmarkDotNet v0.14.0, macOS Sequoia 15.0.1 (24A348) [Darwin 24.0.0]
Apple M1 Pro, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.4 (8.0.424.16909), Arm64 RyuJIT AdvSIMD


```
| Method                                     | Mean       | Error     | StdDev    | Ratio | Rank | Gen0   | Allocated | Alloc Ratio |
|------------------------------------------- |-----------:|----------:|----------:|------:|-----:|-------:|----------:|------------:|
| GetYearFromSpanWithManualConversionForeach |   3.643 ns | 0.0046 ns | 0.0041 ns |  0.02 |    1 |      - |         - |          NA |
| GetYearFromSpanWithManualConversionFor     |   3.645 ns | 0.0077 ns | 0.0065 ns |  0.02 |    1 |      - |         - |          NA |
| GetYearFromSpan                            |   7.992 ns | 0.0097 ns | 0.0081 ns |  0.05 |    2 |      - |         - |          NA |
| GetYearFromSubstring                       |  12.469 ns | 0.0180 ns | 0.0150 ns |  0.08 |    3 | 0.0051 |      32 B |          NA |
| GetYearFromSplit                           |  42.052 ns | 0.1272 ns | 0.1062 ns |  0.27 |    4 | 0.0255 |     160 B |          NA |
| GetYearFromDateTime                        | 158.194 ns | 0.2632 ns | 0.2198 ns |  1.00 |    5 |      - |         - |          NA |
