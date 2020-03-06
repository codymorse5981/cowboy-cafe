/* Author: Cody Morse
 * Class: MenuItemSelectionControl.xaml.cs
 * Description: Handles MenuItemSelectionControl class for application (WPF)
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
using PointOfSale.EntreeCustomization;
using PointOfSale.SideCustomization;
using PointOfSale.DrinkCustomization;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Constructor for OrderControl
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();

        }


        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            // Order to add item to
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext expected to be order");

            // May not need customized
            if (screen != null)
            {
                // Need ancestor to load customization screen
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                // Add item to customization screen
                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
            order.Add(item);
        }
        /// <summary>
        /// Adds Cowpoke Chili to List 
        /// </summary>
        private void CowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new CowpokeChili(), new CowpokeChiliCustomization());
        }
        /// <summary>
        /// Adds Rustler's Ribs to List 
        /// </summary>
        private void RustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// Adds Pecos Pulled Pork to List
        /// </summary>
        private void PecosPork_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new PecosPulledPork(), new PecosPulledPorkCustomization());
        }
        /// <summary>
        /// Adds Trail Burger to List
        /// </summary>
        private void TrailBurger_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new TrailBurger(), new TrailBurgerCustomization());
        }

        /// <summary>
        /// Adds Dakota Double Burger to List
        /// </summary>
        private void DakotaBurger_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new DakotaDoubleBurger(), new DakotaDoubleBurgerCustomization());
        }

        /// <summary>
        /// Adds Texas Triple Burger to List
        /// </summary>
        private void TexasBurger_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new TexasTripleBurger(), new TexasTripleBurgerCustomization());
        }

        /// <summary>
        /// Adds Angry Chicken to List
        /// </summary>
        private void AngryChicken_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new AngryChicken(), new AngryChickenCustomization());
        }

        /// <summary>
        /// Adds Chili Cheese Fries to List
        /// </summary>
        private void ChiliFries_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new ChiliCheeseFries(), new ChiliCheeseFriesCustomization());
        }

        /// <summary>
        /// Adds Corn Dodgers to List 
        /// </summary>
        private void CornDodgers_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new CornDodgers(), new CornDodgersCustomization());
        }

        /// <summary>
        /// Adds Pan de Campo to List
        /// </summary>
        private void PanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new PanDeCampo(), new PandeCampoCustomization());
        }

        /// <summary>
        /// Adds Baked Beans to List
        /// </summary>
        private void BakedBeans_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new BakedBeans(), new BakedBeansCustomization());
        }

        /// <summary>
        /// Adds Jerked Soda to List 
        /// </summary>
        private void JerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new JerkedSoda(), new JerkedSodaCustomization());
        }

        /// <summary>
        /// Adds Texas Tea to List
        /// </summary>
        private void TexasTea_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new TexasTea(), new TexasTeaCustomization());
        }

        /// <summary>
        /// Adds Water to List 
        /// </summary>
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new Water(), new WaterCustomization());
        }

        /// <summary>
        /// Adds Cowboy Coffee to List 
        /// </summary>
        private void CowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            AddItemAndOpenCustomizationScreen(new CowboyCoffee(), new CowboyCoffeeCustomization());
        }
    }
}
