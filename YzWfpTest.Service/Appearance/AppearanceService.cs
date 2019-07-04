using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace YzWfpTest.Services.Appearance
{
    public class AppearanceService : IAppearanceService
    {
        public void ApplyTheme(bool useLightTheme)
        {
            string themeName = "Dark";

            if (useLightTheme)
            {
                themeName = "Light";
            }

            var newThemeDict = new ResourceDictionary { Source = new Uri($"/YzWpfTest;component/Resources/Themes/{themeName}.xaml", UriKind.RelativeOrAbsolute) };

            Application.Current.Resources.MergedDictionaries.Add(newThemeDict);
        }
    }
}
