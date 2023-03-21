``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|                             Method |                Job |            Runtime | TotalRecords |      Mean |     Error |    StdDev |
|----------------------------------- |------------------- |------------------- |------------- |----------:|----------:|----------:|
|             ArrayWhereAnyEquals948 |           .NET 7.0 |           .NET 7.0 |          100 |  32.77 ns |  0.300 ns |  0.281 ns |
|                  ArrayAnyEquals948 |           .NET 7.0 |           .NET 7.0 |          100 |  38.26 ns |  0.792 ns |  1.428 ns |
|    ArrayWhereEquals948FirstDefault |           .NET 7.0 |           .NET 7.0 |          100 |  33.58 ns |  0.126 ns |  0.111 ns |
|       ArrayFirstOrDefaultEquals948 |           .NET 7.0 |           .NET 7.0 |          100 |  35.85 ns |  0.490 ns |  0.458 ns |
|             ArrayWhereAnyEquals948 | .NET Framework 4.8 | .NET Framework 4.8 |          100 |  34.40 ns |  0.057 ns |  0.050 ns |
|                  ArrayAnyEquals948 | .NET Framework 4.8 | .NET Framework 4.8 |          100 |  40.41 ns |  0.218 ns |  0.204 ns |
|    ArrayWhereEquals948FirstDefault | .NET Framework 4.8 | .NET Framework 4.8 |          100 |  40.89 ns |  0.312 ns |  0.292 ns |
|       ArrayFirstOrDefaultEquals948 | .NET Framework 4.8 | .NET Framework 4.8 |          100 |  41.14 ns |  0.302 ns |  0.235 ns |
|            ArrayWhereGreater948Any |           .NET 7.0 |           .NET 7.0 |          100 | 183.86 ns |  3.607 ns |  9.247 ns |
|                 ArrayAnyGreater948 |           .NET 7.0 |           .NET 7.0 |          100 | 472.16 ns |  9.310 ns |  9.144 ns |
| ArrayWhereGreater948FirstOrDefault |           .NET 7.0 |           .NET 7.0 |          100 | 173.78 ns |  0.615 ns |  0.513 ns |
|      ArrayFirstOrDefaultGreater948 |           .NET 7.0 |           .NET 7.0 |          100 | 466.86 ns |  8.346 ns |  7.399 ns |
|            ArrayWhereGreater948Any | .NET Framework 4.8 | .NET Framework 4.8 |          100 | 183.63 ns |  0.746 ns |  0.698 ns |
|                 ArrayAnyGreater948 | .NET Framework 4.8 | .NET Framework 4.8 |          100 | 543.38 ns | 10.629 ns | 13.053 ns |
| ArrayWhereGreater948FirstOrDefault | .NET Framework 4.8 | .NET Framework 4.8 |          100 | 187.11 ns |  0.583 ns |  0.546 ns |
|      ArrayFirstOrDefaultGreater948 | .NET Framework 4.8 | .NET Framework 4.8 |          100 | 538.15 ns | 10.735 ns | 16.713 ns |
