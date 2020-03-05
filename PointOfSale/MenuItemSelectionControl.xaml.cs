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

        /// <summary>
        /// Adds Cowpoke Chili to List 
        /// </summary>
        private void CowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new CowpokeChili();
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(new CowpokeChiliCustomization());
            }
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
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new PecosPulledPork();
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(new PecosPulledPorkCustomization());
            }
        }

        /// <summary>
        /// Adds Trail Burger to List
        /// </summary>
        private void TrailBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new TrailBurger();
                var screen = new TrailerBurgerCustomization();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(new CowpokeChiliCustomization());
            }
        }

        /// <summary>
        /// Adds Dakota Double Burger to List
        /// </summary>
        private void DakotaBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new DakotaDoubleBurger();
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(new DakotaDoubleBurgerCustomization());
            }
        }

        /// <summary>
        /// Adds Texas Triple Burger to List
        /// </summary>
        private void TexasBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new TexasTripleBurger();
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(new TexasTripleBurgerCustomization());
            }
        }

        /// <summary>
        /// Adds Angry Chicken to List
        /// </summary>
        private void AngryChicken_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new AngryChicken();
                var screen = new AngryChickenCustomization();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(new AngryChickenCustomization());
            }
        }

        /// <summary>
        /// Adds Chili Cheese Fries to List
        /// </summary>
        private void ChiliFries_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var side = new ChiliCheeseFries();
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(new ChiliCheeseFriesCustomization());
            }
        }

        /// <summary>
        /// Adds Corn Dodgers to List 
        /// </summary>
        private void CornDodgers_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var side = new CornDodgers();
                var screen = new CornDodgersCustomization();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(new CornDodgersCustomization());
            }
        }

        /// <summary>
        /// Adds Pan de Campo to List
        /// </summary>
        private void PanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                {
                    var side = new PanDeCampo();
                    var screen = new PandeCampoCustomization();
                    screen.DataContext = side;
                    order.Add(side);
                    orderControl.SwapScreen(new PandeCampoCustomization());
                }
            }
        }

        /// <summary>
        /// Adds Baked Beans to List
        /// </summary>
        private void BakedBeans_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var side = new BakedBeans();
                var screen = new BakedBeansCustomization();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(new BakedBeansCustomization());
            }
        }

        /// <summary>
        /// Adds Jerked Soda to List 
        /// </summary>
        private void JerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new JerkedSoda();
                var screen = new JerkedSodaCustomization();
                screen.DataContext = drink;
                order.Add(drink);
                orderControl.SwapScreen(new JerkedSodaCustomization());
            }
        }

        /// <summary>
        /// Adds Texas Tea to List
        /// </summary>
        private void TexasTea_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new TexasTea();
                var screen = new TexasTeaCustomization();
                screen.DataContext = drink;
                order.Add(drink);
                orderControl.SwapScreen(new TexasTeaCustomization());
            }
        }

        /// <summary>
        /// Adds Water to List 
        /// </summary>
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new Water();
                var screen = new WaterCustomization();
                screen.DataContext = drink;
                order.Add(drink);
                orderControl.SwapScreen(new WaterCustomization());
            }
        }

        /// <summary>
        /// Adds Cowboy Coffee to List 
        /// </summary>
        private void CowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new CowboyCoffee();
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = drink;
                order.Add(drink);
                orderControl.SwapScreen(new CowboyCoffeeCustomization());
            }
        }
    }
}
