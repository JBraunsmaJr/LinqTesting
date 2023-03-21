``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|                             Method |                Job |            Runtime | TotalRecords |     Mean |    Error |   StdDev |
|----------------------------------- |------------------- |------------------- |------------- |---------:|---------:|---------:|
|             ArrayWhereAnyEquals948 |           .NET 7.0 |           .NET 7.0 |           10 | 32.88 ns | 0.263 ns | 0.246 ns |
|                  ArrayAnyEquals948 |           .NET 7.0 |           .NET 7.0 |           10 | 38.69 ns | 0.777 ns | 1.233 ns |
|    ArrayWhereEquals948FirstDefault |           .NET 7.0 |           .NET 7.0 |           10 | 35.29 ns | 0.597 ns | 0.559 ns |
|       ArrayFirstOrDefaultEquals948 |           .NET 7.0 |           .NET 7.0 |           10 | 35.49 ns | 0.670 ns | 0.626 ns |
|             ArrayWhereAnyEquals948 | .NET Framework 4.8 | .NET Framework 4.8 |           10 | 35.11 ns | 0.290 ns | 0.272 ns |
|                  ArrayAnyEquals948 | .NET Framework 4.8 | .NET Framework 4.8 |           10 | 40.58 ns | 0.764 ns | 0.714 ns |
|    ArrayWhereEquals948FirstDefault | .NET Framework 4.8 | .NET Framework 4.8 |           10 | 40.46 ns | 0.275 ns | 0.257 ns |
|       ArrayFirstOrDefaultEquals948 | .NET Framework 4.8 | .NET Framework 4.8 |           10 | 40.89 ns | 0.432 ns | 0.404 ns |
|            ArrayWhereGreater948Any |           .NET 7.0 |           .NET 7.0 |           10 | 40.51 ns | 0.828 ns | 2.138 ns |
|                 ArrayAnyGreater948 |           .NET 7.0 |           .NET 7.0 |           10 | 58.70 ns | 1.193 ns | 2.089 ns |
| ArrayWhereGreater948FirstOrDefault |           .NET 7.0 |           .NET 7.0 |           10 | 41.18 ns | 0.839 ns | 0.999 ns |
|      ArrayFirstOrDefaultGreater948 |           .NET 7.0 |           .NET 7.0 |           10 | 59.17 ns | 1.163 ns | 1.031 ns |
|            ArrayWhereGreater948Any | .NET Framework 4.8 | .NET Framework 4.8 |           10 | 41.06 ns | 0.579 ns | 0.541 ns |
|                 ArrayAnyGreater948 | .NET Framework 4.8 | .NET Framework 4.8 |           10 | 63.56 ns | 1.057 ns | 0.989 ns |
| ArrayWhereGreater948FirstOrDefault | .NET Framework 4.8 | .NET Framework 4.8 |           10 | 44.23 ns | 0.468 ns | 0.438 ns |
|      ArrayFirstOrDefaultGreater948 | .NET Framework 4.8 | .NET Framework 4.8 |           10 | 62.26 ns | 1.212 ns | 1.245 ns |
