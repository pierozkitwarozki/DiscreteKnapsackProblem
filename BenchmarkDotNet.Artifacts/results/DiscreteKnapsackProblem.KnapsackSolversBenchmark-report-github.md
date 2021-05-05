``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-9700K CPU 3.60GHz (Coffee Lake), 1 CPU, 8 logical and 8 physical cores
.NET Core SDK=5.0.104
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                          Method | maxWeight | elementsCount | maxElementWeight | maxElementValue |         Mean |       Error |      StdDev | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---------- |-------------- |----------------- |---------------- |-------------:|------------:|------------:|-----:|-------:|------:|------:|----------:|
|     GetRecursiveRandomBenchmark |         ? |             ? |                ? |               ? | 523,645.6 ns | 8,988.58 ns | 8,407.92 ns |    8 |      - |     - |     - |     192 B |
|   GetApproximateRandomBenchmark |         ? |             ? |                ? |               ? |     687.4 ns |     3.54 ns |     3.31 ns |    5 | 0.1755 |     - |     - |    1104 B |
|   GetRecursiveConcreteBenchmark |       100 |            10 |               30 |              30 |   3,760.9 ns |     9.28 ns |     8.23 ns |    7 | 0.0191 |     - |     - |     128 B |
| GetApproximateConcreteBenchmark |       100 |            10 |               30 |              30 |     406.8 ns |     3.57 ns |     3.33 ns |    3 | 0.1349 |     - |     - |     848 B |
|   GetRecursiveConcreteBenchmark |       120 |            20 |               30 |              30 |   2,078.3 ns |     2.43 ns |     1.90 ns |    6 | 0.0191 |     - |     - |     128 B |
| GetApproximateConcreteBenchmark |       120 |            20 |               30 |              30 |     366.5 ns |     1.90 ns |     1.77 ns |    2 | 0.1249 |     - |     - |     784 B |
|   GetRecursiveConcreteBenchmark |       140 |            25 |               30 |              40 |     551.8 ns |     0.97 ns |     0.81 ns |    4 | 0.0172 |     - |     - |     112 B |
| GetApproximateConcreteBenchmark |       140 |            25 |               30 |              40 |     334.3 ns |     1.50 ns |     1.41 ns |    1 | 0.1144 |     - |     - |     720 B |
