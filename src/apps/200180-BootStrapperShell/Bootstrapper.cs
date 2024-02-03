﻿//using Unity;
//using Prism.Unity;
using BootstrapperShell.Views;
using System.Windows;
using Prism.Ioc;
using Prism.DryIoc;

namespace BootstrapperShell
{
    class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
