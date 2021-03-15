``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 5 3600X, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.201
  [Host]     : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT
  DefaultJob : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT


```
|            Method |     Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |---------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|           ForLoop | 10.45 ns | 0.028 ns | 0.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|       ForEachLoop | 22.72 ns | 0.194 ns | 0.172 ns |  2.17 |    0.02 |      - |     - |     - |         - |
| ForEachLambdaLoop | 25.02 ns | 0.196 ns | 0.183 ns |  2.39 |    0.01 | 0.0076 |     - |     - |      64 B |
