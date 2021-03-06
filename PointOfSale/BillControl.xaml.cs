﻿/* Author: Cody Morse
 * Class: BillControl.xaml.cs
 * Description: Handles BillControl class for application (WPF)
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {

        // Using a DependencyProperty as the backing store for the Denomination Property.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                "Denomination",                     // The name of the property
                typeof(Bills),                      // The type of the property
                typeof(BillControl),                // The property's control
                new PropertyMetadata(Bills.One)   // The Property Medata
                );

        // Using a DependencyProperty as the backing store for the Denomination Property.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QuantityInDrawerProperty =
            DependencyProperty.Register(
                "QuantityInDrawer",                     // The name of the property
                typeof(int),                      // The type of the property
                typeof(BillControl),                // The property's control
                new PropertyMetadata(0)   // The Property Medata
                );

        /// <summary>
        /// The DependencyProperty backing the Quantity property
        /// </summary>
        public static readonly DependencyProperty QuantityGivenProperty =
                DependencyProperty.Register(
                    "QuantityGiven",
                    typeof(int),
                    typeof(BillControl),
                    new FrameworkPropertyMetadata(
                        0,
                        FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                    )
                );

        /// <summary>
        /// The denomination of the coin
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// The quantity of the coin denomination
        /// </summary>
        public int QuantityInDrawer
        {
            get { return (int)GetValue(QuantityInDrawerProperty); }
            set { SetValue(QuantityInDrawerProperty, value); }
        }


        /// <summary>
        /// The quantity of the coin denomination
        /// </summary>
        public int QuantityGiven
        {
            get { return (int)GetValue(QuantityGivenProperty); }
            set { SetValue(QuantityGivenProperty, value); }
        }

        /// <summary>
        /// Initialize the UserControl
        /// </summary>
        public BillControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Increases the quantity of the bound coin
        /// </summary>
        /// <param name="sender">The coinage quanity</param>
        /// <param name="args">The event args</param>
        public void OnAddClicked(object sender, RoutedEventArgs args)
        {
            QuantityGiven++;
        }

        /// <summary>
        /// Decreases the quantity of the bound coin
        /// </summary>
        /// <param name="sender">The coinage quanity</param>
        /// <param name="args">The event args</param>
        public void OnRemoveClicked(object sender, RoutedEventArgs args)
        {
            QuantityGiven--;
        }
    }
}
