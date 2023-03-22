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
|  GreaterThan |           .NET 7.0 |           .NET 7.0 | 30.15 ns | 0.353 ns | 0.313 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 | 16.43 ns | 0.303 ns | 0.268 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 20.84 ns | 0.287 ns | 0.254 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 | 16.27 ns | 0.246 ns | 0.230 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 20.86 ns | 0.172 ns | 0.160 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 | 16.48 ns | 0.268 ns | 0.251 ns |
|  GreaterThan | .NET Framework 4.8 | .NET Framework 4.8 | 28.25 ns | 0.567 ns | 0.557 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 | 15.31 ns | 0.123 ns | 0.109 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 20.18 ns | 0.245 ns | 0.218 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 | 15.35 ns | 0.105 ns | 0.093 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 20.00 ns | 0.158 ns | 0.132 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 | 15.18 ns | 0.160 ns | 0.149 ns |
