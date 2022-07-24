using System.Runtime.InteropServices;

namespace RustLib;

[StructLayout(LayoutKind.Sequential)]
public struct SampleStruct
{
    public Int16 first;
    public Int16 second;
}