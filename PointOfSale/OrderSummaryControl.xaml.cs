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
            var orderControl = this.FindAncestor<OrderControl>();
            IOrderItem item = (IOrderItem)((ListBox)sender).SelectedItem;
            // Entrees ---------------------------------------------------------------------
            if (orderList.SelectedItem is AngryChicken angryChicken)
            {
                orderControl.DataContext = item;
                orderControl?.SwapScreen(new AngryChickenCustomization(angryChicken));
            }
            else if (orderList.SelectedItem is CowpokeChili cowpokeChili)
            {
                orderControl.DataContext = item;
                orderControl?.SwapScreen(new CowpokeChiliCustomization(cowpokeChili));
            }
            else if (orderList.SelectedItem is DakotaDoubleBurger dakotaDouble)
            {
                orderControl.DataContext = item;
                orderControl?.SwapScreen(new DakotaDoubleBurgerCustomization(dakotaDouble));
            }
            else if (orderList.SelectedItem is PecosPulledPork pecosPulledPork)
            {
                orderControl.DataContext = item;
                orderControl?.SwapScreen(new PecosPulledPorkCustomization(pecosPulledPork));
            }
            else if (orderList.SelectedItem is TexasTripleBurger texasTriple)
            {
                orderControl.DataContext = item;
                orderControl?.SwapScreen(new TexasTripleBurgerCustomization(texasTriple));
            }
            else if (orderList.SelectedItem is TrailBurger trailBurger)
            {
                orderControl.DataContext = item;
                orderControl?.SwapScreen(new TrailBurgerCustomization(trailBurger));
            }

            // Sides ---------------------------------------------------------------------
            else if (orderList.SelectedItem is BakedBeans bakedBeans)
            {
                orderControl?.SwapScreen(new BakedBeansCustomization(bakedBeans));
            }
            else if (orderList.SelectedItem is ChiliCheeseFries chiliCheeseFries)
            {
                orderControl?.SwapScreen(new ChiliCheeseFriesCustomization(chiliCheeseFries));
            }
            else if (orderList.SelectedItem is CornDodgers cornDodgers)
            {
                orderControl?.SwapScreen(new CornDodgersCustomization(cornDodgers));
            }
            else if (orderList.SelectedItem is PanDeCampo panDeCampo)
            {
                orderControl?.SwapScreen(new PandeCampoCustomization(panDeCampo));
            }

            // Drinks ---------------------------------------------------------------------
            else if (orderList.SelectedItem is CowboyCoffee cowboyCoffee)
            {
                orderControl?.SwapScreen(new CowboyCoffeeCustomization(cowboyCoffee));
                
            }
            else if (orderList.SelectedItem is JerkedSoda jerkedSoda)
            {
                orderControl?.SwapScreen(new JerkedSodaCustomization(jerkedSoda));
            }
            else if (orderList.SelectedItem is TexasTea texasTea)
            {
                orderControl?.SwapScreen(new TexasTeaCustomization(texasTea));
            }
            else if (orderList.SelectedItem is Water water)
            {
                orderControl?.SwapScreen(new WaterCustomization(water));
            }

            // All else ---------------------------------------------------------------------
            else
            {
                orderControl?.SwapScreen(new MenuItemSelectionControl());
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
