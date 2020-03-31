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
using System.ComponentModel;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// Notifier of Property Changes 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Initializes event handlers and new order
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            this.DataContext = new Order();
            CompleteOrderButton.Click += CompleteOrderButtonClicked;
            CancelOrderButton.Click += CancelOrderButtonClicked;
            ItemSelectButton.Click += ItemSelectButtonClicked;
        }

        /// <summary>
        /// Handles screen swapping... Swaps with customization method
        /// </summary>
        /// <param name="element">Customization method screen to swap to</param>
        public void SwapScreen(FrameworkElement element)
        {
            if (element != null)
            {
                Container.Child = element;
            }
        }

        /// <summary>
        /// Initializes a new order upon click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            var transactionControl = new TransactionControl();
            transactionControl.DataContext = this.DataContext;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
            SwapScreen(transactionControl);
            

            /// Creates new order     
            //this.DataContext = new Order();
            // SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Initializes a new order upon click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            /// Creates new order
            this.DataContext = new Order();
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Returns to main menu screen to select another item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ItemSelectButtonClicked(object sender, RoutedEventArgs e)
        {
            SwapScreen(new MenuItemSelectionControl());
        }
    }
}
    
