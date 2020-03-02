﻿/* Author: Cody Morse
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        
        /// <summary>
        /// Order variable for class
        /// </summary>
        public Order OrderList;

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
            if (DataContext is Order order)
            {
                order.Add(new CowpokeChili());
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
            if (DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// Adds Trail Burger to List
        /// </summary>
        private void TrailBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
            }
        }

        /// <summary>
        /// Adds Dakota Double Burger to List
        /// </summary>
        private void DakotaBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// Adds Texas Triple Burger to List
        /// </summary>
        private void TexasBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// Adds Angry Chicken to List
        /// </summary>
        private void AngryChicken_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// Adds Chili Cheese Fries to List
        /// </summary>
        private void ChiliFries_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// Adds Corn Dodgers to List 
        /// </summary>
        private void CornDodgers_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// Adds Pan de Campo to List
        /// </summary>
        private void PanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// Adds Baked Beans to List
        /// </summary>
        private void BakedBeans_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// Adds Jerked Soda to List 
        /// </summary>
        private void JerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// Adds Texas Tea to List
        /// </summary>
        private void TexasTea_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }

        /// <summary>
        /// Adds Water to List 
        /// </summary>
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }

        /// <summary>
        /// Adds Cowboy Coffee to List 
        /// </summary>
        private void CowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }
    }
}
