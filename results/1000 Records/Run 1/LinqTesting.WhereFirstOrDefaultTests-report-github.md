``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2 [AttachedDebugger]
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|       Method |                Job |            Runtime |        Mean |     Error |    StdDev |
|------------- |------------------- |------------------- |------------:|----------:|----------:|
|  GreaterThan |           .NET 7.0 |           .NET 7.0 | 1,518.54 ns |  7.107 ns |  6.300 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 |    23.44 ns |  0.216 ns |  0.202 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 1,517.40 ns |  6.269 ns |  5.864 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 |    23.60 ns |  0.310 ns |  0.290 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 1,516.63 ns |  6.892 ns |  6.447 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 |    23.42 ns |  0.112 ns |  0.105 ns |
|  GreaterThan | .NET Framework 4.8 | .NET Framework 4.8 | 1,540.25 ns |  9.288 ns |  8.688 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 |    27.60 ns |  0.164 ns |  0.153 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 1,546.57 ns | 12.125 ns | 11.341 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 |    27.02 ns |  0.070 ns |  0.059 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 1,533.80 ns |  6.468 ns |  5.401 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 |    27.57 ns |  0.144 ns |  0.135 ns |
