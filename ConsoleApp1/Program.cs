// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Diagnostics.Metrics;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using ConsoleApp1;
using Microsoft.Extensions.Diagnostics.Metrics.Testing;

Console.WriteLine("Hello, World!");

///////////////////// This part is to do with counters ////////////////////////////////////

var meter = new Meter("Microlise.Tristan.StopwatchCounter");
var cStart = meter.CreateCounter<long>("LoopStart","Count","Counts the number of started stopwatch tests.");
var cFinish= meter.CreateCounter<long>("LoopFinish", "Count", "Counts the number of finished stopwatch tests.");

var metricCollector = new MetricCollector<int>(meter.Scope, "StopwatchCounter", "CounterPrototype");
/*

Run this command in the terminal window in order to be able to view counter information:

dotnet tool install --global dotnet-counters


Run this command in D:\repos\trisuglow\benchmarking to monitor the counters

dotnet-counters monitor --name ConsoleApp1 Microlise.Tristan.StopwatchCounter

*/


//////////////////////////////////////////////////////////////////////////////////////////////


///////////////////// This part is to do with stopwatches ////////////////////////////////////

var sw = new Stopwatch();
for (var stopwatchTest = 0; stopwatchTest < 1000; stopwatchTest += 1)
{
    cStart.Add(1);
    sw.Restart();
    Thread.Sleep(123);
    sw.Stop();
    Console.WriteLine($"Loop {stopwatchTest}: Time Recorded = {sw.Elapsed.ToString()}.");
    cFinish.Add(1);
}

//////////////////////////////////////////////////////////////////////////////////////////////


///////////////////// This part is to do with counters ////////////////////////////////////
var measurements = metricCollector.GetMeasurementSnapshot();

//////////////////////////////////////////////////////////////////////////////////////////////



///////////////////// This part is to do with benchmarking ////////////////////////////////////


var config = DefaultConfig.Instance;
var summary = BenchmarkRunner.Run<Benchmarks>(config, args);

// Use this to select benchmarks from the console:
var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);



// Use `dotnet run --project ConsoleApp1 -c Release` to run the benchmark and get the output in the Terminal window.


