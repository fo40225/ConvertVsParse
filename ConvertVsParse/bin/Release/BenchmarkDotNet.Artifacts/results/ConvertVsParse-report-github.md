``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Xeon CPU E3-1230 V2 3.30GHz, 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.6.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3101.0
  DefaultJob : .NET Framework 4.6.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3101.0


```
|  Method |       N |     Mean |    Error |    StdDev |
|-------- |-------- |---------:|---------:|----------:|
| **Convert** |    **1000** | **111.9 us** | **1.350 us** | **1.2628 us** |
|   Parse |    1000 | 106.7 us | 1.076 us | 0.9537 us |
| **Convert** | **1000000** | **111.6 us** | **1.953 us** | **1.5249 us** |
|   Parse | 1000000 | 106.9 us | 1.070 us | 0.9488 us |
