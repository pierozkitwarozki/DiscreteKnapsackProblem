``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-9700K CPU 3.60GHz (Coffee Lake), 1 CPU, 8 logical and 8 physical cores
.NET Core SDK=5.0.104
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                        Method |             Mean |           Error |          StdDev | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |-----------------:|----------------:|----------------:|-----:|-------:|------:|------:|----------:|
|   GetRecursiveSolverBenchmark | 247,612,766.7 ns | 4,408,338.09 ns | 4,123,562.18 ns |    2 |      - |     - |     - |     144 B |
| GetApproximateSolverBenchmark |         830.2 ns |         5.42 ns |         4.80 ns |    1 | 0.1631 |     - |     - |    1024 B |
