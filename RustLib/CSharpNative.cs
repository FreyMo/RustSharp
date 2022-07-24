namespace RustLib;

public static class CSharpNative
{
    public static int Fibonacci(int n)
    {
        return n switch
        {
            0 => 1,
            1 => 1,
            _ => Fibonacci(n - 1) + Fibonacci(n - 2)
        };
    }
}