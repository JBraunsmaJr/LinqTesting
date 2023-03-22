``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|       Method |                Job |            Runtime |     Mean |    Error |   StdDev |
|------------- |------------------- |------------------- |---------:|---------:|---------:|
|  GreaterThan |           .NET 7.0 |           .NET 7.0 | 30.30 ns | 0.287 ns | 0.240 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 | 25.93 ns | 0.333 ns | 0.295 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 27.10 ns | 0.492 ns | 0.460 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 | 25.44 ns | 0.322 ns | 0.285 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 26.81 ns | 0.344 ns | 0.288 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 | 25.71 ns | 0.232 ns | 0.217 ns |
|  GreaterThan | .NET Framework 4.8 | .NET Framework 4.8 | 31.23 ns | 0.314 ns | 0.294 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 | 25.03 ns | 0.151 ns | 0.142 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 26.74 ns | 0.072 ns | 0.060 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 | 25.05 ns | 0.211 ns | 0.198 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 26.90 ns | 0.113 ns | 0.106 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 | 25.15 ns | 0.173 ns | 0.162 ns |
