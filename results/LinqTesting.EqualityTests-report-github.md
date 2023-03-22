``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|       Method |                Job |            Runtime |      Mean |     Error |    StdDev |
|------------- |------------------- |------------------- |----------:|----------:|----------:|
|      Greater |           .NET 7.0 |           .NET 7.0 | 0.1478 ns | 0.0222 ns | 0.0207 ns |
|     LessThan |           .NET 7.0 |           .NET 7.0 | 0.1403 ns | 0.0072 ns | 0.0067 ns |
| GreaterEqual |           .NET 7.0 |           .NET 7.0 | 0.1479 ns | 0.0083 ns | 0.0078 ns |
|    LessEqual |           .NET 7.0 |           .NET 7.0 | 0.1349 ns | 0.0094 ns | 0.0088 ns |
|       Equals |           .NET 7.0 |           .NET 7.0 | 0.1460 ns | 0.0079 ns | 0.0074 ns |
|     NotEqual |           .NET 7.0 |           .NET 7.0 | 0.1477 ns | 0.0140 ns | 0.0131 ns |
|      Greater | .NET Framework 4.8 | .NET Framework 4.8 | 0.1185 ns | 0.0110 ns | 0.0102 ns |
|     LessThan | .NET Framework 4.8 | .NET Framework 4.8 | 0.1137 ns | 0.0179 ns | 0.0158 ns |
| GreaterEqual | .NET Framework 4.8 | .NET Framework 4.8 | 0.1512 ns | 0.0271 ns | 0.0266 ns |
|    LessEqual | .NET Framework 4.8 | .NET Framework 4.8 | 0.1156 ns | 0.0062 ns | 0.0058 ns |
|       Equals | .NET Framework 4.8 | .NET Framework 4.8 | 0.1805 ns | 0.0242 ns | 0.0237 ns |
|     NotEqual | .NET Framework 4.8 | .NET Framework 4.8 | 0.1233 ns | 0.0179 ns | 0.0167 ns |
