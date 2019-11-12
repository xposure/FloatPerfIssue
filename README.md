// Validating benchmarks:
// ***** BenchmarkRunner: Start   *****
// ***** Found 1 benchmark(s) in total *****
// ***** Building 1 exe(s) in Parallel: Start   *****
Unable to find .sln file. Will use current directory P:\Temp\FloatPerfDegrades to search for project file. If you don't use .sln file on purpose it should not be a problem.
// start dotnet restore  /p:UseSharedCompilation=false /p:BuildInParallel=false /m:1 in P:\Temp\FloatPerfDegrades\bin\Release\netcoreapp3.0\ac789e53-5ebd-4e4f-a214-43f687060747
// command took 1.25s and exited with 0
// start dotnet build -c Release  --no-restore /p:UseSharedCompilation=false /p:BuildInParallel=false /m:1 in P:\Temp\FloatPerfDegrades\bin\Release\netcoreapp3.0\ac789e53-5ebd-4e4f-a214-43f687060747
// command took 2.07s and exited with 0
// ***** Done, took 00:00:03 (3.43 sec)   *****
// Found 1 benchmarks:
//   FloatBenchmark.HelpMe: QuickJob(InvocationCount=2000, IterationCount=5, LaunchCount=1, WarmupCount=3)

// **************************
// Benchmark: FloatBenchmark.HelpMe: QuickJob(InvocationCount=2000, IterationCount=5, LaunchCount=1, WarmupCount=3)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet "ac789e53-5ebd-4e4f-a214-43f687060747.dll" --benchmarkName "FloatPerfDegrades.FloatBenchmark.HelpMe" --job "QuickJob" --benchmarkId 0 in P:\Temp\FloatPerfDegrades\bin\Release\netcoreapp3.0\ac789e53-5ebd-4e4f-a214-43f687060747\bin\Release\netcoreapp3.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
// GC=Concurrent Workstation
// Job: QuickJob(InvocationCount=2000, IterationCount=5, LaunchCount=1, WarmupCount=3)

OverheadJitting  1: 16 op, 347200.00 ns, 21.7000 us/op
WorkloadJitting  1: 16 op, 3026300.00 ns, 189.1438 us/op

OverheadWarmup   1: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadWarmup   2: 2000 op, 3300.00 ns, 1.6500 ns/op
OverheadWarmup   3: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadWarmup   4: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadWarmup   5: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadWarmup   6: 2000 op, 3300.00 ns, 1.6500 ns/op

OverheadActual   1: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadActual   2: 2000 op, 3500.00 ns, 1.7500 ns/op
OverheadActual   3: 2000 op, 3300.00 ns, 1.6500 ns/op
OverheadActual   4: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadActual   5: 2000 op, 3300.00 ns, 1.6500 ns/op
OverheadActual   6: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadActual   7: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadActual   8: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadActual   9: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadActual  10: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadActual  11: 2000 op, 4300.00 ns, 2.1500 ns/op
OverheadActual  12: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadActual  13: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadActual  14: 2000 op, 3400.00 ns, 1.7000 ns/op
OverheadActual  15: 2000 op, 3400.00 ns, 1.7000 ns/op

WorkloadWarmup   1: 2000 op, 315840200.00 ns, 157.9201 us/op
WorkloadWarmup   2: 2000 op, 316210400.00 ns, 158.1052 us/op
WorkloadWarmup   3: 2000 op, 2438708500.00 ns, 1.2194 ms/op

// BeforeActualRun
WorkloadActual   1: 2000 op, 8283742000.00 ns, 4.1419 ms/op
WorkloadActual   2: 2000 op, 8317858600.00 ns, 4.1589 ms/op
WorkloadActual   3: 2000 op, 8298193300.00 ns, 4.1491 ms/op
WorkloadActual   4: 2000 op, 8323174200.00 ns, 4.1616 ms/op
WorkloadActual   5: 2000 op, 8283488200.00 ns, 4.1417 ms/op

// AfterActualRun
WorkloadResult   1: 2000 op, 8283738600.00 ns, 4.1419 ms/op
WorkloadResult   2: 2000 op, 8317855200.00 ns, 4.1589 ms/op
WorkloadResult   3: 2000 op, 8298189900.00 ns, 4.1491 ms/op
WorkloadResult   4: 2000 op, 8323170800.00 ns, 4.1616 ms/op
WorkloadResult   5: 2000 op, 8283484800.00 ns, 4.1417 ms/op

// AfterAll
// Benchmark Process 17356 has exited with code 0

Mean = 4.1506 ms, StdErr = 0.0042 ms (0.10%); N = 5, StdDev = 0.0093 ms
Min = 4.1417 ms, Q1 = 4.1418 ms, Median = 4.1491 ms, Q3 = 4.1603 ms, Max = 4.1616 ms
IQR = 0.0185 ms, LowerFence = 4.1141 ms, UpperFence = 4.1879 ms
ConfidenceInterval = [4.1148 ms; 4.1865 ms] (CI 99.9%), Margin = 0.0359 ms (0.86% of Mean)
Skewness = 0.12, Kurtosis = 0.83, MValue = 2

// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\FloatPerfDegrades.FloatBenchmark-report.csv
  BenchmarkDotNet.Artifacts\results\FloatPerfDegrades.FloatBenchmark-report-github.md
  BenchmarkDotNet.Artifacts\results\FloatPerfDegrades.FloatBenchmark-report.html

// * Detailed results *
FloatBenchmark.HelpMe: QuickJob(InvocationCount=2000, IterationCount=5, LaunchCount=1, WarmupCount=3)
Runtime = .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT; GC = Concurrent Workstation
Mean = 4.1506 ms, StdErr = 0.0042 ms (0.10%); N = 5, StdDev = 0.0093 ms
Min = 4.1417 ms, Q1 = 4.1418 ms, Median = 4.1491 ms, Q3 = 4.1603 ms, Max = 4.1616 ms
IQR = 0.0185 ms, LowerFence = 4.1141 ms, UpperFence = 4.1879 ms
ConfidenceInterval = [4.1148 ms; 4.1865 ms] (CI 99.9%), Margin = 0.0359 ms (0.86% of Mean)
Skewness = 0.12, Kurtosis = 0.83, MValue = 2
-------------------- Histogram --------------------
[4.137 ms ; 4.166 ms) | @@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i7-5930K CPU 3.50GHz (Broadwell), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]   : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  QuickJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

Job=QuickJob  InvocationCount=2000  IterationCount=5  
LaunchCount=1  WarmupCount=3  

| Method |     Mean |     Error |    StdDev |
|------- |---------:|----------:|----------:|
| HelpMe | 4.151 ms | 0.0359 ms | 0.0093 ms |

// * Legends *
  Mean   : Arithmetic mean of all measurements
  Error  : Half of 99.9% confidence interval
  StdDev : Standard deviation of all measurements
  1 ms   : 1 Millisecond (0.001 sec)

// ***** BenchmarkRunner: End *****
// ** Remained 0 benchmark(s) to run **
Run time: 00:00:45 (45.43 sec), executed benchmarks: 1

Global total time: 00:00:48 (48.87 sec), executed benchmarks: 1
// * Artifacts cleanup *
