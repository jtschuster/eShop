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
            span = new Span<byte>((void*)Marshal.AllocHGlobal(1024 * 32), 1024 * 32);
        }
        return span;
    }
}
