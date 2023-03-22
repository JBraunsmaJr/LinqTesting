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
|  GreaterThan |           .NET 7.0 |           .NET 7.0 | 32.68 ns | 0.352 ns | 0.312 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 | 28.15 ns | 0.524 ns | 0.538 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 29.88 ns | 0.470 ns | 0.439 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 | 27.94 ns | 0.540 ns | 0.478 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 28.92 ns | 0.473 ns | 0.442 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 | 28.18 ns | 0.567 ns | 0.676 ns |
|  GreaterThan | .NET Framework 4.8 | .NET Framework 4.8 | 33.80 ns | 0.151 ns | 0.141 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 | 29.29 ns | 0.152 ns | 0.143 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 31.20 ns | 0.204 ns | 0.191 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 | 33.82 ns | 0.692 ns | 1.035 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 31.07 ns | 0.210 ns | 0.196 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 | 29.17 ns | 0.201 ns | 0.188 ns |
