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
    /// Interaction logic for TrailBurgerCustomization.xaml
    /// </summary>
    public partial class TrailerBurgerCustomization : UserControl
    {
        private TrailBurger t;
        public TrailerBurgerCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TrailBurger trailBurger)
                {
                    t = trailBurger;
                }
            }
        }

        private void OnBunClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TrailBurger trailBurger)
                {
                    trailBurger.HoldBun();
                }
            }
        }

        private void OnKetchupClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TrailBurger trailBurger)
                {
                    trailBurger.HoldKetchup();
                }
            }
        }
        private void OnMustardClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TrailBurger trailBurger)
                {
                    trailBurger.HoldMustard();
                }
            }
        }

        private void OnPickleClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TrailBurger trailBurger)
                {
                    trailBurger.HoldPickle();
                }
            }
        }

        private void OnCheeseClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TrailBurger trailBurger)
                {
                    trailBurger.HoldCheese();
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
