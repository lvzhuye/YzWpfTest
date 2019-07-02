﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace YzWpfControls.Converters
{
    public class ResizeModeMinMaxButtonVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null && values.Length == 2 && parameter is string)
            {
                bool windowPropValue = System.Convert.ToBoolean(values[0]);
                ResizeMode windowResizeMode = (ResizeMode)values[1];
                string whichButton = System.Convert.ToString(parameter);

                switch (windowResizeMode)
                {
                    case ResizeMode.NoResize:
                        return Visibility.Collapsed;
                    case ResizeMode.CanMinimize:
                        if (whichButton == "MIN")
                        {
                            return (windowPropValue ? Visibility.Visible : Visibility.Collapsed);
                        }
                        return Visibility.Collapsed;
                    case ResizeMode.CanResize:
                        return (windowPropValue ? Visibility.Visible : Visibility.Collapsed);
                    case ResizeMode.CanResizeWithGrip:
                        return (windowPropValue ? Visibility.Visible : Visibility.Collapsed);
                    default:
                        return (windowPropValue ? Visibility.Visible : Visibility.Collapsed);
                }
            }
            return Visibility.Visible;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
