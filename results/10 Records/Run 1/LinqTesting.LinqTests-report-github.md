``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]             : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9139.0), X64 RyuJIT VectorSize=256


```
|                     Method |                Job |            Runtime | TotalRecords |      Mean |    Error |    StdDev |    Median | Ratio | RatioSD |
|--------------------------- |------------------- |------------------- |------------- |----------:|---------:|----------:|----------:|------:|--------:|
|   ManualGreater948_Foreach |           .NET 7.0 |           .NET 7.0 |          100 | 152.30 ns | 0.828 ns |  0.734 ns | 152.48 ns |  1.00 |    0.00 |
|            WhereGreaterAny |           .NET 7.0 |           .NET 7.0 |          100 | 170.82 ns | 0.627 ns |  0.490 ns | 170.74 ns |  1.12 |    0.01 |
|                 AnyGreater |           .NET 7.0 |           .NET 7.0 |          100 | 445.48 ns | 8.221 ns |  7.287 ns | 442.76 ns |  2.93 |    0.05 |
|      FirstOrDefaultGreater |           .NET 7.0 |           .NET 7.0 |          100 | 432.56 ns | 8.418 ns | 16.813 ns | 432.57 ns |  2.86 |    0.08 |
| WhereGreaterFirstOrDefault |           .NET 7.0 |           .NET 7.0 |          100 | 178.69 ns | 3.587 ns |  8.934 ns | 174.96 ns |  1.19 |    0.05 |
|       FirstOrDefaultEquals |           .NET 7.0 |           .NET 7.0 |          100 |  33.74 ns | 0.646 ns |  0.605 ns |  33.67 ns |  0.22 |    0.00 |
|  WhereEqualsFirstOrDefault |           .NET 7.0 |           .NET 7.0 |          100 |  29.89 ns | 0.145 ns |  0.136 ns |  29.88 ns |  0.20 |    0.00 |
|                  AnyEquals |           .NET 7.0 |           .NET 7.0 |          100 |  34.80 ns | 0.235 ns |  0.196 ns |  34.79 ns |  0.23 |    0.00 |
|             WhereEqualsAny |           .NET 7.0 |           .NET 7.0 |          100 |  29.67 ns | 0.104 ns |  0.097 ns |  29.66 ns |  0.19 |    0.00 |
|                            |                    |                    |              |           |          |           |           |       |         |
|   ManualGreater948_Foreach | .NET Framework 4.8 | .NET Framework 4.8 |          100 | 130.56 ns | 0.390 ns |  0.345 ns | 130.40 ns |  1.00 |    0.00 |
|            WhereGreaterAny | .NET Framework 4.8 | .NET Framework 4.8 |          100 | 178.22 ns | 1.697 ns |  1.588 ns | 178.00 ns |  1.36 |    0.01 |
|                 AnyGreater | .NET Framework 4.8 | .NET Framework 4.8 |          100 | 480.36 ns | 9.506 ns | 10.566 ns | 481.30 ns |  3.67 |    0.09 |
|      FirstOrDefaultGreater | .NET Framework 4.8 | .NET Framework 4.8 |          100 | 482.72 ns | 9.369 ns |  8.306 ns | 481.06 ns |  3.70 |    0.06 |
| WhereGreaterFirstOrDefault | .NET Framework 4.8 | .NET Framework 4.8 |          100 | 179.27 ns | 2.030 ns |  1.585 ns | 179.60 ns |  1.37 |    0.01 |
|       FirstOrDefaultEquals | .NET Framework 4.8 | .NET Framework 4.8 |          100 |  32.88 ns | 0.655 ns |  0.805 ns |  32.69 ns |  0.25 |    0.01 |
|  WhereEqualsFirstOrDefault | .NET Framework 4.8 | .NET Framework 4.8 |          100 |  33.78 ns | 0.686 ns |  0.817 ns |  33.55 ns |  0.26 |    0.01 |
|                  AnyEquals | .NET Framework 4.8 | .NET Framework 4.8 |          100 |  33.27 ns | 0.512 ns |  0.427 ns |  33.20 ns |  0.25 |    0.00 |
|             WhereEqualsAny | .NET Framework 4.8 | .NET Framework 4.8 |          100 |  30.77 ns | 0.634 ns |  1.191 ns |  30.62 ns |  0.23 |    0.01 |
