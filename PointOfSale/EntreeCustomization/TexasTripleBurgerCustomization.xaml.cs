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
    /// Interaction logic for TexasTrip;eBurgerCustomization.xaml
    /// </summary>
    public partial class TexasTripleBurgerCustomization : UserControl
    {
        private TexasTripleBurger t;
        public TexasTripleBurgerCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    t = texasTriple;
                }
            }
        }

        private void OnBunClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    texasTriple.HoldBun();
                }
            }
        }

        private void OnKetchupClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    texasTriple.HoldKetchup();
                }
            }
        }
        private void OnMustardClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    texasTriple.HoldMustard();
                }
            }
        }

        private void OnPickleClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    texasTriple.HoldPickle();
                }
            }
        }

        private void OnCheeseClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    texasTriple.HoldCheese();
                }
            }
        }
        private void OnTomatoClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    texasTriple.HoldTomato();
                }
            }
        }

        private void OnLettuceClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    texasTriple.HoldLettuce();
                }
            }
        }

        private void OnMayoClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    texasTriple.HoldMayo();
                }
            }
        }

        private void OnBaconClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    texasTriple.HoldBacon();
                }
            }
        }

        private void OnEggClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TexasTripleBurger texasTriple)
                {
                    texasTriple.HoldEgg();
                }
            }
        }

        public void OnBackClick(object sender, RoutedEventArgs args)
        {

        }
    }
}
