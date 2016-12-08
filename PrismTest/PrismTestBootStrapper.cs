using Microsoft.Practices.ServiceLocation;
using Prism.Mef;
using System.ComponentModel.Composition.Hosting;
using System.Windows;
using PrismTest.Modules.MefTest;
using Prism.Regions;
using PrismTest.Infrastructure.Behaviors;

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
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(MefTestModule).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(AutoPopulateExportedViewsBehavior).Assembly));
        }

        protected override IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
        {
            var factory = base.ConfigureDefaultRegionBehaviors();
            factory.AddIfMissing("AutoPopulateExportedViewsBehavior", typeof(AutoPopulateExportedViewsBehavior));
            return factory;
        }
    }
}
