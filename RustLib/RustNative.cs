using System.Runtime.InteropServices;

namespace RustLib;

public static class RustNative
{
    public static int Fibonacci(Int32 n) => fibonacci(n);
    
    [DllImport("samplelib")]
    private static extern Int32 fibonacci(Int32 n);
    
    // public static SampleStruct GetSampleStruct() => get_sample_struct();
    
    // [DllImport("samplelib")]
    // private static extern SampleStruct get_sample_struct();
}