``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1413/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.202
  [Host]     : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2


```
|                    Method |       Mean |    Error |    StdDev |     Median |
|-------------------------- |-----------:|---------:|----------:|-----------:|
|                  WhereAny | 1,522.5 ns | 23.29 ns |  21.78 ns | 1,515.7 ns |
|                       Any | 4,098.1 ns | 81.60 ns | 182.52 ns | 4,004.9 ns |
|            MyExtensionAny | 1,291.9 ns | 25.18 ns |  23.55 ns | 1,280.7 ns |
|       WhereFirstOrDefault | 1,576.7 ns | 31.42 ns |  78.26 ns | 1,555.9 ns |
|            FirstOrDefault | 4,367.0 ns | 86.42 ns |  88.75 ns | 4,356.3 ns |
| MyExtensionFirstOrDefault | 1,319.2 ns | 26.40 ns |  42.63 ns | 1,316.2 ns |
|                 ForEachIt |   238.3 ns |  4.72 ns |  12.52 ns |   238.1 ns |
