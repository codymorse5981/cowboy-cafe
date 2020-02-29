/* Author: Cody Morse
 * Class: MenuItemSelectionControl.xaml.cs
 * Description: Handles MenuItemSelectionControl class for application (WPF)
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Instantiations for WPF button clicks\
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            CompleteOrderButton.Click += CompleteOrderButtonClicked;
            CancelOrderButton.Click += CancelOrderButtonClicked;
            ItemSelectButton.Click += ItemSelectButtonClicked;
        }

        public void CompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            /// Creates new order
            this.DataContext = new Order();
        }

        public void CancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            /// Creates new order
            this.DataContext = new Order();
        }

        public void ItemSelectButtonClicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException("Needs to Still be implemented.");
        }
    }
}
