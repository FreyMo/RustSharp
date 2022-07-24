using BenchmarkDotNet.Running;

namespace RustLib.Cli;

public static class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<FibonacciBench>();
    }
}