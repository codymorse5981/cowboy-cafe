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
    /// Interaction logic for DakotaDoubleBurgerCustomization.xaml
    /// </summary>
    public partial class DakotaDoubleBurgerCustomization : UserControl
    {
        private DakotaDoubleBurger d;
        public DakotaDoubleBurgerCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DakotaDoubleBurger dakotaDouble)
                {
                    d = dakotaDouble;
                }
            }
        }

        private void OnBunClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DakotaDoubleBurger dakotaDouble)
                {
                    dakotaDouble.HoldBun();
                }
            }
        }

        private void OnKetchupClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DakotaDoubleBurger dakotaDouble)
                {
                    dakotaDouble.HoldKetchup();
                }
            }
        }
        private void OnMustardClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DakotaDoubleBurger dakotaDouble)
                {
                    dakotaDouble.HoldMustard();
                }
            }
        }

        private void OnPickleClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DakotaDoubleBurger dakotaDouble)
                {
                    dakotaDouble.HoldPickle();
                }
            }
        }

        private void OnCheeseClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DakotaDoubleBurger dakotaDouble)
                {
                    dakotaDouble.HoldCheese();
                }
            }
        }
        private void OnTomatoClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DakotaDoubleBurger dakotaDouble)
                {
                    dakotaDouble.HoldTomato();
                }
            }
        }

        private void OnLettuceClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DakotaDoubleBurger dakotaDouble)
                {
                    dakotaDouble.HoldLettuce();
                }
            }
        }

        private void OnMayoClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DakotaDoubleBurger dakotaDouble)
                {
                    dakotaDouble.HoldMayo();
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
