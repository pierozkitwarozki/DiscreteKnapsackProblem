``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-9700K CPU 3.60GHz (Coffee Lake), 1 CPU, 8 logical and 8 physical cores
.NET Core SDK=5.0.104
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                          Method | maxWeight | elementsCount | maxElementWeight | maxElementValue |        Mean |     Error |    StdDev | Rank |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---------- |-------------- |----------------- |---------------- |------------:|----------:|----------:|-----:|-------:|-------:|------:|----------:|
|   GetRecursiveConcreteBenchmark |       100 |            10 |               30 |              30 | 61,104.8 ns | 245.61 ns | 217.73 ns |    8 |      - |      - |     - |     176 B |
|   GetRecursiveConcreteBenchmark |       140 |            25 |               30 |              40 | 20,786.1 ns |  78.10 ns |  69.24 ns |    7 | 0.0305 |      - |     - |     240 B |
|   GetApproximateRandomBenchmark |         ? |             ? |                ? |               ? |  1,221.4 ns |   7.54 ns |   6.68 ns |    6 | 0.2499 |      - |     - |    1568 B |
| GetApproximateConcreteBenchmark |       100 |            10 |               30 |              30 |    893.9 ns |   7.42 ns |   6.94 ns |    5 | 0.2193 | 0.0010 |     - |    1376 B |
| GetApproximateConcreteBenchmark |       120 |            20 |               30 |              30 |    804.1 ns |   3.08 ns |   2.41 ns |    4 | 0.1984 |      - |     - |    1248 B |
| GetApproximateConcreteBenchmark |       140 |            25 |               30 |              40 |    708.6 ns |   7.05 ns |   6.60 ns |    3 | 0.1755 |      - |     - |    1104 B |
|   GetRecursiveConcreteBenchmark |       120 |            20 |               30 |              30 |    564.5 ns |   8.69 ns |   8.13 ns |    2 | 0.0172 |      - |     - |     112 B |
|     GetRecursiveRandomBenchmark |         ? |             ? |                ? |               ? |    285.1 ns |   2.46 ns |   2.18 ns |    1 | 0.0153 |      - |     - |      96 B |
