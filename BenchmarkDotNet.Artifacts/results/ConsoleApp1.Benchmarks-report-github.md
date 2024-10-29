```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4169/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11800H 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.400
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method | Mean        | Error       | StdDev       |
|------- |------------:|------------:|-------------:|
| Slow   | 96,966.9 ns | 6,262.59 ns | 17,765.92 ns |
| Fast   |  1,831.0 ns |    83.80 ns |    245.77 ns |
| Quick  |    182.9 ns |    12.40 ns |     36.38 ns |
