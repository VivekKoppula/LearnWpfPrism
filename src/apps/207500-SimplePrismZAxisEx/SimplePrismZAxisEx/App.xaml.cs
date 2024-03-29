﻿using ModuleGreen;
using ModuleRed;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using SimplePrismZAxisEx.Views;
using System.Diagnostics;
using System.Windows;

namespace SimplePrismZAxisEx
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleGreeenModule>();
            moduleCatalog.AddModule<ModuleRedModule>();
        }

    }
}
