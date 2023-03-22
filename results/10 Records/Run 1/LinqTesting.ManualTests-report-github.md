``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|       Method |                Job |            Runtime |      Mean |     Error |    StdDev |    Median |
|------------- |------------------- |------------------- |----------:|----------:|----------:|----------:|
|  GreaterThan |           .NET 7.0 |           .NET 7.0 | 0.9450 ns | 0.0269 ns | 0.0251 ns | 0.9387 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 | 0.2521 ns | 0.0155 ns | 0.0145 ns | 0.2550 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 0.4357 ns | 0.0322 ns | 0.0783 ns | 0.4075 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 | 0.2514 ns | 0.0300 ns | 0.0281 ns | 0.2538 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 0.4035 ns | 0.0213 ns | 0.0199 ns | 0.4054 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 | 0.2275 ns | 0.0090 ns | 0.0071 ns | 0.2281 ns |
|  GreaterThan | .NET Framework 4.8 | .NET Framework 4.8 | 1.0523 ns | 0.0144 ns | 0.0127 ns | 1.0504 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 | 0.4466 ns | 0.0053 ns | 0.0049 ns | 0.4468 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 0.6144 ns | 0.0070 ns | 0.0055 ns | 0.6124 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 | 0.4446 ns | 0.0245 ns | 0.0229 ns | 0.4327 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 0.6603 ns | 0.0193 ns | 0.0181 ns | 0.6518 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 | 0.4260 ns | 0.0067 ns | 0.0059 ns | 0.4256 ns |
