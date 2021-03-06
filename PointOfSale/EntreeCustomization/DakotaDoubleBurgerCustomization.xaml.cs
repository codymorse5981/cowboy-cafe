﻿/* Author: Cody Morse
 * Class: DakotaDoubleBurgerCustomization.cs
 * Description: Handles DakotaDoubleBurgerCustomization class
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
    /// Interaction logic for DakotaDoubleBurgerCustomization.xaml
    /// </summary>
    public partial class DakotaDoubleBurgerCustomization : UserControl
    {
        public DakotaDoubleBurgerCustomization()
        {
            InitializeComponent();           
        }

        private DakotaDoubleBurger doubleBurger;
        public DakotaDoubleBurgerCustomization(DakotaDoubleBurger d)
        {
            doubleBurger = d;
            InitializeComponent();
        }
    }
}
