using EventAggregatorDemonstration.ViewModels;
using Microsoft.Practices.Prism.PubSubEvents;
using System;
using System.Collections.Generic;
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

namespace EventAggregatorDemonstration
{
    /// <summary>
    /// Interaktionslogik für TargetView.xaml
    /// </summary>
    public partial class TargetView : UserControl
    {
        public TargetView()
        {
            this.DataContext = new TargetViewModel();
            InitializeComponent();
        }
    }
}
