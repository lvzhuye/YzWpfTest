using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YzWpfControls.Native
{
    public static partial class NativeMethods
    {
        [DllImport("user32.dll", EntryPoint = "GetMonitorInfoW", ExactSpelling = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetMonitorInfo(IntPtr hMonitor, [Out] MONITORINFO lpmi);

        [DllImport("user32.dll")]
        internal static extern IntPtr MonitorFromWindow(IntPtr handle, uint flags);
    }
}
