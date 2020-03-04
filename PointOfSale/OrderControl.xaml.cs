/* Author: Cody Morse
 * Class: OrderControl.xaml.cs
 * Description: Handles OrderControl class for application (WPF)
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            this.DataContext = new Order();
            CompleteOrderButton.Click += CompleteOrderButtonClicked;
            CancelOrderButton.Click += CancelOrderButtonClicked;
            ItemSelectButton.Click += ItemSelectButtonClicked;


        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
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
    
