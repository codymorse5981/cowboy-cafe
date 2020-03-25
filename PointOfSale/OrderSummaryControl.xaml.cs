/* Author: Cody Morse
 * Class: OrderControlSummary.xaml.cs
 * Description: Handles OrderControlSummary class for application (WPF)
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
using System.ComponentModel;
using PointOfSale;
using PointOfSale.DrinkCustomization;
using PointOfSale.EntreeCustomization;
using PointOfSale.SideCustomization;
using System.Collections.ObjectModel;

    
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

        public void OnItemSelection(object sender, SelectionChangedEventArgs args)
        {
            FrameworkElement screen;
            OrderControl orderControl = null;

            var orderItem = orderList.SelectedItem;

            // Entrees ---------------------------------------------------------------------
            if (orderList.SelectedItem is IOrderItem item)
            {
                if (item is AngryChicken angryChicken)
                {

                    screen = new AngryChickenCustomization(angryChicken);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

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
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = water;
                        orderControl.SwapScreen(screen);
                    }
                }

                // All else ---------------------------------------------------------------------
                else
                {
                    // Need ancestor to load customization screen
                    orderControl = this.FindAncestor<OrderControl>();

                    if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                    // Add item to customization screen
                    orderControl?.SwapScreen(new MenuItemSelectionControl());
                }
            }
        }
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
