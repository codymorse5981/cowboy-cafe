﻿/* Author: Cody Morse
 * Class: JerkedSodaCustomization.cs
 * Description: Handles JerkedSodaCustomization class
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

namespace PointOfSale.DrinkCustomization
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        public JerkedSodaCustomization()
        {
            InitializeComponent();
        }

        private JerkedSoda soda;
        public JerkedSodaCustomization(JerkedSoda s)
        {
            soda = s;
            InitializeComponent();
        }
    }
}
