// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;

namespace HelloWorld
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }     

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(HelloWorldModule.HelloWorldModule));
        }

        
    }
}
