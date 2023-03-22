``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2 [AttachedDebugger]
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|       Method |                Job |            Runtime |        Mean |     Error |     StdDev |
|------------- |------------------- |------------------- |------------:|----------:|-----------:|
|  GreaterThan |           .NET 7.0 |           .NET 7.0 | 222.6675 ns | 4.2797 ns |  4.5792 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 |   0.4258 ns | 0.0330 ns |  0.0688 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 221.0857 ns | 3.3055 ns |  3.0920 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 |   0.4100 ns | 0.0326 ns |  0.0545 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 220.9731 ns | 2.7364 ns |  2.5596 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 |   0.3205 ns | 0.0135 ns |  0.0126 ns |
|  GreaterThan | .NET Framework 4.8 | .NET Framework 4.8 | 446.5207 ns | 6.6276 ns |  6.1994 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 |   0.3816 ns | 0.0145 ns |  0.0136 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 448.2901 ns | 8.7441 ns | 10.7385 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 |   0.3467 ns | 0.0055 ns |  0.0049 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 446.2571 ns | 8.7960 ns |  9.0328 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 |   0.3946 ns | 0.0147 ns |  0.0137 ns |
