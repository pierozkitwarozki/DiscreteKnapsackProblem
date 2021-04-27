``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-9700K CPU 3.60GHz (Coffee Lake), 1 CPU, 8 logical and 8 physical cores
.NET Core SDK=5.0.104
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                    Method |     Mean |   Error |  StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |---------:|--------:|--------:|-----:|------:|------:|------:|----------:|
| GetSolverFromCFGBenchmark | 529.7 ms | 3.20 ms | 2.84 ms |    2 |     - |     - |     - |    1352 B |
|  GetSolverSecondBenchmark | 432.1 ms | 7.75 ms | 7.25 ms |    1 |     - |     - |     - |     288 B |
