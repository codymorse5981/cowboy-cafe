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
        private Order OrderList = new Order();
        public OrderControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds Cowpoke Chili to List View
        /// </summary>
        private void CowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new CowpokeChili());
            
        }

        /// <summary>
        /// Adds Rustler's Ribs to List View
        /// </summary>
        private void RustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new RustlersRibs());
        }

        /// <summary>
        /// Adds Pecos Pulled Pork to List View
        /// </summary>
        private void PecosPork_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Adds Trail Burger to List View
        /// </summary>
        private void TrailBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new TrailBurger());
        }

        /// <summary>
        /// Adds Dakota Double Burger to List View
        /// </summary>
        private void DakotaBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Adds Texas Triple Burger to List View
        /// </summary>
        private void TexasBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Adds Angry Chicken to List View
        /// </summary>
        private void AngryChicken_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new AngryChicken());
        }

        /// <summary>
        /// Adds Chili Cheese Fries to List View
        /// </summary>
        private void ChiliFries_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Adds Corn Dodgers to List View
        /// </summary>
        private void CornDodgers_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new CornDodgers());
        }

        /// <summary>
        /// Adds Pan de Campo to List View
        /// </summary>
        private void PanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new PanDeCampo());
        }

        /// <summary>
        /// Adds Baked Beans to List View
        /// </summary>
        private void BakedBeans_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new BakedBeans());
        }

        /// <summary>
        /// Adds Jerked Soda to List View
        /// </summary>
        private void JerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new JerkedSoda());
        }

        /// <summary>
        /// Adds Texas Tea to List View
        /// </summary>
        private void TexasTea_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new TexasTea());
        }

        /// <summary>
        /// Adds Water to List View
        /// </summary>
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new Water());
        }

        /// <summary>
        /// Adds Cowboy Coffee to List View
        /// </summary>
        private void CowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new CowboyCoffee());
        }
    }
}
