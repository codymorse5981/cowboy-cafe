﻿/* Author: Cody Morse
 * Class: TrailBurgerCustomization.cs
 * Description: Handles TrailBurgerCustomization class
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

namespace PointOfSale.EntreeCustomization
{
    /// <summary>
    /// Interaction logic for TrailBurgerCustomization.xaml
    /// </summary>
    public partial class TrailBurgerCustomization : UserControl
    {
        public TrailBurgerCustomization()
        {
            InitializeComponent();           
        }

        private TrailBurger trailBurger;
        public TrailBurgerCustomization(TrailBurger t)
        {
            trailBurger = t;
            InitializeComponent();
        }
    }
}
