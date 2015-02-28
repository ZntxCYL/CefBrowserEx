using System;
using System.Runtime.InteropServices;

namespace CefBrowserEx.Operation
{
    public class NativeMethod
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    }
}