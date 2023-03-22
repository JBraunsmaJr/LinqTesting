``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2 [AttachedDebugger]
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|       Method |                Job |            Runtime |        Mean |     Error |     StdDev |      Median |
|------------- |------------------- |------------------- |------------:|----------:|-----------:|------------:|
|  GreaterThan |           .NET 7.0 |           .NET 7.0 | 4,207.00 ns | 72.895 ns |  77.997 ns | 4,189.74 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 |    12.59 ns |  0.091 ns |   0.081 ns |    12.57 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 3,987.81 ns | 72.290 ns |  67.620 ns | 3,935.93 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 |    12.43 ns |  0.106 ns |   0.100 ns |    12.46 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 4,034.11 ns | 44.682 ns |  39.610 ns | 4,044.96 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 |    12.51 ns |  0.113 ns |   0.106 ns |    12.48 ns |
|  GreaterThan | .NET Framework 4.8 | .NET Framework 4.8 | 4,114.30 ns | 37.982 ns |  31.717 ns | 4,132.12 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 |    12.07 ns |  0.237 ns |   0.221 ns |    11.98 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 4,330.63 ns | 86.426 ns | 235.129 ns | 4,244.74 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 |    12.19 ns |  0.259 ns |   0.277 ns |    12.11 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 4,119.19 ns | 43.389 ns |  33.875 ns | 4,131.03 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 |    11.96 ns |  0.192 ns |   0.170 ns |    11.91 ns |
