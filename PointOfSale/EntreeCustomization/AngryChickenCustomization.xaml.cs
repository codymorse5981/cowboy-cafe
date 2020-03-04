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

namespace PointOfSale.EntreeCustomization
{
    /// <summary>
    /// Interaction logic for AngryChickenCustomization.xaml
    /// </summary>
    public partial class AngryChickenCustomization : UserControl
    {
        private AngryChicken c;
        public AngryChickenCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is AngryChicken chicken)
                {
                    c = chicken;
                }
            }
        }

        private void OnBreadClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is AngryChicken chicken)
                {
                    chicken.HoldBread();
                }
            }
        }

        private void OnPickleClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is AngryChicken chicken)
                {
                    chicken.HoldPickle();
                }
            }
        }
        public void OnBackClick(object sender, RoutedEventArgs args)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                orderControl.SwapScreen(new MenuItemSelectionControl()); ;
            }
        }
    }
}
