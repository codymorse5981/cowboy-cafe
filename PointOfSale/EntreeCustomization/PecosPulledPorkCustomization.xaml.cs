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
    /// Interaction logic for PecosPulledPorkCustomization.xaml
    /// </summary>
    public partial class PecosPulledPorkCustomization : UserControl
    {
        private PecosPulledPork p;
        public PecosPulledPorkCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PecosPulledPork pecosPulled)
                {
                    p = pecosPulled;
                }
            }
        }
        private void OnBreadClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PecosPulledPork pecosPulled)
                {
                    pecosPulled.HoldBread();
                }
            }
        }

        private void OnPickleClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PecosPulledPork pecosPulled)
                {
                    pecosPulled.HoldPickle();
                }
            }
        }
        
        public void OnBackClick(object sender, RoutedEventArgs args)
        {

        }
    }
}
