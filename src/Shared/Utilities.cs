using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

internal static class Utilities
{
    public static Span<byte> GetImageData()
    {
        Span<byte> span = default;
        unsafe
        {
            span = new Span<byte>((void*)Marshal.AllocHGlobal(4096), 4096);
        }
        return span;
    }
}
