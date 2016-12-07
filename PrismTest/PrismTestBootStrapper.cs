using Microsoft.Practices.ServiceLocation;
using Prism.Mef;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Modularity;

namespace PrismTest
{
    class PrismTestBootStrapper: MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            //return Container.GetExportedValue<Shell>();
            return ServiceLocator.Current.GetInstance<Shell>();
        }
        protected override void InitializeModules()
        {
            base.InitializeModules();
            Application.Current.MainWindow = Shell as Shell;
            Application.Current.MainWindow.Show();
        }
        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(PrismTestBootStrapper).Assembly));
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            //return base.CreateModuleCatalog();
            return new ConfigurationModuleCatalog();
        }
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }
        protected override void RegisterBootstrapperProvidedTypes()
        {
            base.RegisterBootstrapperProvidedTypes();
        }
    }
}
