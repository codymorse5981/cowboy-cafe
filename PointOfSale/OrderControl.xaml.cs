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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }
        private void CowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        private void RustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new RustlersRibs());
        }

        private void PecosPork_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }

        private void TrailBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TrailBurger());
        }

        private void DakotaBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }

        private void TexasBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }

        private void AngryChicken_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new AngryChicken());
        }

        private void ChiliFries_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }

        private void CornDodgers_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CornDodgers());
        }

        private void PanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PanDeCampo());
        }

        private void BakedBeans_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new BakedBeans());
        }

        private void JerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new JerkedSoda());
        }

        private void TexasTea_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTea());
        }

        private void Water_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new Water());
        }

        private void CowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowboyCoffee());
        }
    }
}
