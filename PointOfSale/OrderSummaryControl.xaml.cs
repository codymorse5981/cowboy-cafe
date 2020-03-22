/* Author: Cody Morse
 * Class: OrderControlSummary.xaml.cs
 * Description: Handles OrderControlSummary class for application (WPF)
  */

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
using System.Drawing;
using System.IO;
using System.Resources;
using System.ComponentModel;
using PointOfSale;
    
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        public void OnItemSelection(object sender, SelectionChangedEventArgs args)
        {
            var orderControl = this.FindAncestor<OrderControl>().DataContext as OrderControl;
            var choseItem = (ListBox)sender;
            var item = choseItem.SelectedItem;
           
            var screen = item as FrameworkElement;
            orderControl?.SwapScreen(screen);
        }
    }
}
