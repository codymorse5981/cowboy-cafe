using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale.SideCustomization
{
    /// <summary>
    /// Interaction logic for BakedBeansCustomization.xaml
    /// </summary>
    public partial class BakedBeansCustomization : UserControl
    {
        public BakedBeansCustomization()
        {
            InitializeComponent();
        }

        public void OnBackClick(object sender, RoutedEventArgs args)
        {
            

            var orderControl = this.FindAncestor<OrderControl>();

            FrameworkElement screen = this.Parent as FrameworkElement;
            orderControl.SwapScreen(screen);
        }
    }
}
