``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2 [AttachedDebugger]
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|       Method |                Job |            Runtime |        Mean |      Error |     StdDev |      Median |
|------------- |------------------- |------------------- |------------:|-----------:|-----------:|------------:|
|  GreaterThan |           .NET 7.0 |           .NET 7.0 | 4,059.43 ns |  80.847 ns | 105.124 ns | 4,049.70 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 |    13.16 ns |   0.137 ns |   0.114 ns |    13.12 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 4,237.24 ns |  79.100 ns |  66.052 ns | 4,237.41 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 |    13.49 ns |   0.121 ns |   0.113 ns |    13.46 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 4,446.73 ns | 120.220 ns | 354.472 ns | 4,202.03 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 |    13.00 ns |   0.122 ns |   0.108 ns |    13.00 ns |
|  GreaterThan | .NET Framework 4.8 | .NET Framework 4.8 | 3,905.72 ns |  43.952 ns |  36.702 ns | 3,925.63 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 |    11.68 ns |   0.100 ns |   0.084 ns |    11.67 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 3,912.30 ns |  37.157 ns |  29.009 ns | 3,925.38 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 |    11.81 ns |   0.136 ns |   0.127 ns |    11.76 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 3,885.86 ns |  31.813 ns |  26.565 ns | 3,874.46 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 |    11.78 ns |   0.165 ns |   0.146 ns |    11.75 ns |
