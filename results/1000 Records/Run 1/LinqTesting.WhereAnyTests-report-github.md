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
|  GreaterThan |           .NET 7.0 |           .NET 7.0 | 1,518.31 ns |  9.063 ns |  8.478 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 |    22.56 ns |  0.261 ns |  0.244 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 1,515.70 ns |  5.780 ns |  5.407 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 |    22.44 ns |  0.137 ns |  0.121 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 1,512.78 ns |  5.341 ns |  4.996 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 |    22.59 ns |  0.450 ns |  0.421 ns |
|  GreaterThan | .NET Framework 4.8 | .NET Framework 4.8 | 1,541.55 ns | 12.476 ns | 11.670 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 |    21.96 ns |  0.202 ns |  0.189 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 1,523.75 ns |  6.884 ns |  5.748 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 |    21.95 ns |  0.064 ns |  0.060 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 1,540.73 ns | 12.382 ns | 11.582 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 |    21.97 ns |  0.098 ns |  0.092 ns |
