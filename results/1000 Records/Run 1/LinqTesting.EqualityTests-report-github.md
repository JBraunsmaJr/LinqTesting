``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2 [AttachedDebugger]
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|       Method |                Job |            Runtime |      Mean |     Error |    StdDev |
|------------- |------------------- |------------------- |----------:|----------:|----------:|
|      Greater |           .NET 7.0 |           .NET 7.0 | 0.1555 ns | 0.0191 ns | 0.0179 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 | 0.1541 ns | 0.0098 ns | 0.0092 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 0.1452 ns | 0.0103 ns | 0.0086 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 | 0.1561 ns | 0.0063 ns | 0.0052 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 0.1647 ns | 0.0287 ns | 0.0294 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 | 0.1386 ns | 0.0168 ns | 0.0149 ns |
|      Greater | .NET Framework 4.8 | .NET Framework 4.8 | 0.1241 ns | 0.0146 ns | 0.0137 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 | 0.1405 ns | 0.0269 ns | 0.0265 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 0.0886 ns | 0.0070 ns | 0.0062 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 | 0.1449 ns | 0.0129 ns | 0.0120 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 0.1233 ns | 0.0139 ns | 0.0130 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 | 0.1532 ns | 0.0159 ns | 0.0149 ns |
