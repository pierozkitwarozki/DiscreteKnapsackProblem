``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-9700K CPU 3.60GHz (Coffee Lake), 1 CPU, 8 logical and 8 physical cores
.NET Core SDK=5.0.104
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                          Method | maxWeight | elementsCount | maxElementWeight | maxElementValue |      Mean |     Error |    StdDev |    Median | Rank |     Gen 0 |     Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---------- |-------------- |----------------- |---------------- |----------:|----------:|----------:|----------:|-----:|----------:|----------:|------:|----------:|
| GetApproximateConcreteBenchmark |       170 |            35 |               30 |              50 | 29.447 ms | 0.3308 ms | 0.3094 ms | 29.411 ms |    6 | 5281.2500 | 2156.2500 |     - |  31.79 MB |
|   GetRecursiveConcreteBenchmark |       170 |            35 |               30 |              50 | 29.276 ms | 0.1994 ms | 0.1768 ms | 29.291 ms |    6 | 5281.2500 | 2156.2500 |     - |  31.79 MB |
| GetApproximateConcreteBenchmark |       150 |            33 |               30 |              45 | 28.571 ms | 0.5341 ms | 1.1612 ms | 28.165 ms |    5 | 5000.0000 | 2093.7500 |     - |     30 MB |
|   GetRecursiveConcreteBenchmark |       150 |            33 |               30 |              45 | 27.712 ms | 0.2143 ms | 0.2004 ms | 27.741 ms |    5 | 5000.0000 | 2062.5000 |     - |  29.97 MB |
|   GetRecursiveConcreteBenchmark |       140 |            30 |               30 |              40 | 25.708 ms | 0.5137 ms | 0.6115 ms | 25.403 ms |    4 | 4531.2500 | 1875.0000 |     - |  27.27 MB |
| GetApproximateConcreteBenchmark |       140 |            30 |               30 |              40 | 25.241 ms | 0.1215 ms | 0.1014 ms | 25.224 ms |    4 | 4531.2500 | 1875.0000 |     - |  27.27 MB |
| GetApproximateConcreteBenchmark |       120 |            20 |               30 |              30 | 16.913 ms | 0.2166 ms | 0.2026 ms | 16.867 ms |    3 | 3031.2500 | 1250.0000 |     - |  18.17 MB |
|   GetRecursiveConcreteBenchmark |       120 |            20 |               30 |              30 | 16.802 ms | 0.1576 ms | 0.1474 ms | 16.782 ms |    3 | 3031.2500 | 1250.0000 |     - |  18.18 MB |
| GetApproximateConcreteBenchmark |       100 |            10 |               30 |              30 |  8.919 ms | 0.1779 ms | 0.4194 ms |  8.780 ms |    2 | 1515.6250 |  625.0000 |     - |   9.08 MB |
|   GetRecursiveConcreteBenchmark |       100 |            10 |               30 |              30 |  8.397 ms | 0.0845 ms | 0.0706 ms |  8.370 ms |    1 | 1515.6250 |  625.0000 |     - |   9.08 MB |
