using PrismTest.Infrastructure;
using PrismTest.Infrastructure.Behaviors;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrismTest.Modules.MefTest.Views
{
    /// <summary>
    /// MefTestMainView.xaml 的交互逻辑
    /// </summary>
    [ViewExport(RegionName = RegionNames.MefTestRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class MefTestMainView : UserControl
    {
        public MefTestMainView()
        {
            InitializeComponent();
        }
    }
}
