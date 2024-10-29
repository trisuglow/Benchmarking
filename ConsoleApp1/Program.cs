// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using ConsoleApp1;

Console.WriteLine("Hello, World!");

var config = DefaultConfig.Instance;
var summary = BenchmarkRunner.Run<Benchmarks>(config, args);

// Use this to select benchmarks from the console:
var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);



// Use `dotnet run --project ConsoleApp1 -c Release` to run the benchmark and get the output in the Terminal window.

