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
        [DllImport("shell32.dll")]
        internal static extern uint SHAppBarMessage(int dwMessage, ref APPBARDATA pData);
    }
}
