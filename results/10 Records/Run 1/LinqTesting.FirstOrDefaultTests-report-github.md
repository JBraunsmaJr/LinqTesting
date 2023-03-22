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
|  GreaterThan |           .NET 7.0 |           .NET 7.0 | 30.39 ns | 0.437 ns | 0.388 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 | 17.09 ns | 0.314 ns | 0.278 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 20.87 ns | 0.359 ns | 0.300 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 | 16.58 ns | 0.327 ns | 0.306 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 21.20 ns | 0.395 ns | 0.369 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 | 16.60 ns | 0.275 ns | 0.258 ns |
|  GreaterThan | .NET Framework 4.8 | .NET Framework 4.8 | 28.42 ns | 0.575 ns | 0.747 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 | 15.25 ns | 0.102 ns | 0.095 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 19.99 ns | 0.142 ns | 0.119 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 | 15.07 ns | 0.224 ns | 0.209 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 19.88 ns | 0.192 ns | 0.180 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 | 15.23 ns | 0.094 ns | 0.073 ns |
