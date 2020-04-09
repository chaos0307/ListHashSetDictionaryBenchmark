# ListHashSetDictionaryBenchmark
JustForFun

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.752 (1909/November2018Update/19H2)
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4150.0), X86 LegacyJIT
  .NET 4.7.2 : .NET Framework 4.8 (4.8.4150.0), X86 LegacyJIT


```
|        Method |           Job |       Runtime |             Mean |           Error |          StdDev |    Gen 0 |    Gen 1 |    Gen 2 |  Allocated |
|-------------- |-------------- |-------------- |-----------------:|----------------:|----------------:|---------:|---------:|---------:|-----------:|
|       ListAdd |    .NET 4.7.2 |    .NET 4.7.2 |  10,711,299.8 ns |   190,787.65 ns |   169,128.28 ns | 125.0000 |  62.5000 |  62.5000 |  8389696 B |
|      ListFind |    .NET 4.7.2 |    .NET 4.7.2 |         437.2 ns |         2.74 ns |         2.57 ns |   0.6366 |        - |        - |     1058 B |
|    HashSetAdd |    .NET 4.7.2 |    .NET 4.7.2 |  93,166,154.8 ns | 1,823,042.94 ns | 1,616,080.08 ns | 166.6667 | 166.6667 | 166.6667 | 43111040 B |
|   HashSetFind |    .NET 4.7.2 |    .NET 4.7.2 |         414.8 ns |         0.48 ns |         0.43 ns |        - |        - |        - |          - |
| DictionaryAdd |    .NET 4.7.2 |    .NET 4.7.2 | 102,378,554.8 ns | 1,873,491.84 ns | 1,660,801.71 ns | 333.3333 | 333.3333 | 333.3333 | 53889556 B |
|      DictFind |    .NET 4.7.2 |    .NET 4.7.2 |         383.3 ns |         0.89 ns |         0.84 ns |        - |        - |        - |          - |
|       ListAdd | .NET Core 3.1 | .NET Core 3.1 |               NA |              NA |              NA |        - |        - |        - |          - |
|      ListFind | .NET Core 3.1 | .NET Core 3.1 |               NA |              NA |              NA |        - |        - |        - |          - |
|    HashSetAdd | .NET Core 3.1 | .NET Core 3.1 |               NA |              NA |              NA |        - |        - |        - |          - |
|   HashSetFind | .NET Core 3.1 | .NET Core 3.1 |               NA |              NA |              NA |        - |        - |        - |          - |
| DictionaryAdd | .NET Core 3.1 | .NET Core 3.1 |               NA |              NA |              NA |        - |        - |        - |          - |
|      DictFind | .NET Core 3.1 | .NET Core 3.1 |               NA |              NA |              NA |        - |        - |        - |          - |

Benchmarks with issues:
  Benchmark.ListAdd: .NET Core 3.1(Runtime=.NET Core 3.1)
  Benchmark.ListFind: .NET Core 3.1(Runtime=.NET Core 3.1)
  Benchmark.HashSetAdd: .NET Core 3.1(Runtime=.NET Core 3.1)
  Benchmark.HashSetFind: .NET Core 3.1(Runtime=.NET Core 3.1)
  Benchmark.DictionaryAdd: .NET Core 3.1(Runtime=.NET Core 3.1)
  Benchmark.DictFind: .NET Core 3.1(Runtime=.NET Core 3.1)
