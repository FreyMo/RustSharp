using BenchmarkDotNet.Attributes;

namespace RustLib.Cli;

[MemoryDiagnoser]
public class FibonacciBench
{
    [Params(5, 25)]
    public int N { get; set; }
    
    [Benchmark]
    public int FibonacciRust() => RustNative.Fibonacci(N);
    
    [Benchmark]
    public int FibonacciCsharp() => CSharpNative.Fibonacci(N);
}