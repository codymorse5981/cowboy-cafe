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
    /// Interaction logic for CowpokeChiliCustomization.xaml
    /// </summary>
    public partial class CowpokeChiliCustomization : UserControl
    {
        private CowpokeChili c;
        public CowpokeChiliCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {

                ///    c = chili;
            }
        }

        private void OnCheeseClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                ///chili.HoldCheese();

            }
        }

        private void OnSourCreamClick(object sender, RoutedEventArgs args)
        {
                    ///chili.HoldSourCream();
        }

        private void OnGreenOnionsClick(object sender, RoutedEventArgs arsg)
        {
            ///if (DataContext is Order order)
            ///{
            ///
            ///        chili.HoldGreenOnions();
            ///
            ///}
        }

        private void OnTortillaStripsClick(object sender, RoutedEventArgs arsg)
        {
            ///if (DataContext is Order order)
            ///{

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
