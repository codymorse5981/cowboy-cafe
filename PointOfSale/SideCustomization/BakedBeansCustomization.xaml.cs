﻿/* Author: Cody Morse
 * Class: BakedBeanCustomization.cs
 * Description: Handles BakedBeansCustomization class
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

namespace PointOfSale.SideCustomization
{
    /// <summary>
    /// Interaction logic for BakedBeansCustomization.xaml
    /// </summary>
    public partial class BakedBeansCustomization : UserControl
    {
        public BakedBeansCustomization()
        {
            InitializeComponent();
        }

        private BakedBeans beans;
        public BakedBeansCustomization(BakedBeans b)
        {
            beans = b;
            InitializeComponent();
        }
    }
}
