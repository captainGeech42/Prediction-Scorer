using System;
using System.Runtime.InteropServices;

namespace PredictionScorer
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern bool HideCaret(IntPtr hWnd);
    }
}
