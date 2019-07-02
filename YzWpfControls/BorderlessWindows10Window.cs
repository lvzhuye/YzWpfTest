using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using YzWpfControls.Base;

namespace YzWpfControls
{
    public abstract class BorderlessWindows10Window: BorderlessWindowBase
    {
        static BorderlessWindows10Window()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BorderlessWindows10Window), new FrameworkPropertyMetadata(typeof(BorderlessWindows10Window)));
        }
    }
}
