// API для выделения собственной памяти.
// NativeMemory имеет методы для выделения и освобождения памяти.

using System.Runtime.InteropServices;

unsafe
{
    byte* buffer = (byte*)NativeMemory.Alloc(100);

    NativeMemory.Free(buffer);
}
