/* Author: Cody Morse
 * Class: OrderControlSummary.xaml.cs
 * Description: Handles OrderControlSummary class for application (WPF)
  */

using CowboyCafe.Data;
using PointOfSale.DrinkCustomization;
using PointOfSale.EntreeCustomization;
using PointOfSale.SideCustomization;
using System;
using System.Windows;
using System.Windows.Controls;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();  
        }

        /// <summary>
        /// Allows customization of selected item from summary control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnItemSelection(object sender, SelectionChangedEventArgs args)
        {
            FrameworkElement screen;
            OrderControl orderControl = null;

            // Need ancestor to load customization screen
            orderControl = this.FindAncestor<OrderControl>();

            if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

            // Entrees ---------------------------------------------------------------------
            if (orderList.SelectedItem is IOrderItem item)
            {
                if (item is AngryChicken angryChicken)
                {
                    screen = new AngryChickenCustomization(angryChicken);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = angryChicken;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is CowpokeChili cowpokeChili)
                {
                    screen = new CowpokeChiliCustomization(cowpokeChili);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = cowpokeChili;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is DakotaDoubleBurger dakotaDouble)
                {
                    screen = new DakotaDoubleBurgerCustomization(dakotaDouble);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = dakotaDouble;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is PecosPulledPork pecosPulledPork)
                {
                    screen = new PecosPulledPorkCustomization(pecosPulledPork);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = pecosPulledPork;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is TexasTripleBurger texasTriple)
                {
                    screen = new TexasTripleBurgerCustomization(texasTriple);
                    if (screen != null)
                    {

                        // Add item to customization screen
                        screen.DataContext = texasTriple;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is TrailBurger trailBurger)
                {
                    screen = new TrailBurgerCustomization(trailBurger);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = trailBurger;
                        orderControl.SwapScreen(screen);
                    }
                }

                // Sides ---------------------------------------------------------------------
                else if (orderList.SelectedItem is BakedBeans bakedBeans)
                {
                    screen = new BakedBeansCustomization(bakedBeans);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = bakedBeans;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is ChiliCheeseFries chiliCheeseFries)
                {
                    screen = new ChiliCheeseFriesCustomization(chiliCheeseFries);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = chiliCheeseFries;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is CornDodgers cornDodgers)
                {
                    screen = new CornDodgersCustomization(cornDodgers);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = cornDodgers;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is PanDeCampo panDeCampo)
                {
                    screen = new PandeCampoCustomization(panDeCampo);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = panDeCampo;
                        orderControl.SwapScreen(screen);
                    }
                }

                // Drinks ---------------------------------------------------------------------
                else if (orderList.SelectedItem is CowboyCoffee cowboyCoffee)
                {
                    screen = new CowboyCoffeeCustomization(cowboyCoffee);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = cowboyCoffee;
                        orderControl.SwapScreen(screen);
                    }

                }
                else if (orderList.SelectedItem is JerkedSoda jerkedSoda)
                {
                    screen = new JerkedSodaCustomization(jerkedSoda);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = jerkedSoda;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is TexasTea texasTea)
                {
                    screen = new TexasTeaCustomization(texasTea);
                    if (screen != null)
                    {
                        // Add item to customization screen
                        screen.DataContext = texasTea;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is Water water)
                {
                    screen = new WaterCustomization(water);
                    if (screen != null)
                    {                       
                        // Add item to customization screen
                        screen.DataContext = water;
                        orderControl.SwapScreen(screen);
                    }
                }

                // All else ---------------------------------------------------------------------
                else
                {
                    // Add item to customization screen
                    orderControl?.SwapScreen(new MenuItemSelectionControl());
                }
                orderList.SelectedItem = null;
            }
        }

        /// <summary>
        /// Deletes specific item bound to summary control listbox item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement orderElement)
                {
                    if (orderElement.DataContext is IOrderItem item)
                    {
                        order.Remove(item);                       
                    }
                }
            }
        }
    }
}
