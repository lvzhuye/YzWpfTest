using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using YzWfpTest.Services.Appearance;

namespace YzWpfTest
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell(Window shell)
        {
            Current.MainWindow = shell;
            shell.Show();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            RegisterServices();
            InitializeServices();

            void RegisterServices()
            {
                containerRegistry.RegisterSingleton<IAppearanceService, AppearanceService>();
            }
        }

        private void InitializeServices()
        {
            Container.Resolve<IAppearanceService>().ApplyTheme(false);
        }
    }
}
