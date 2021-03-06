﻿/* Author: Cody Morse
 * Class: TexasTeaCustomization.cs
 * Description: Handles TexasTeaCustomization class
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
    /// Interaction logic for TexasTeaCustomization.xaml
    /// </summary>
    public partial class TexasTeaCustomization : UserControl
    {
        public TexasTeaCustomization()
        {
            InitializeComponent();
        }

        private TexasTea tea;
        public TexasTeaCustomization(TexasTea t)
        {
            tea = t;
            InitializeComponent();
        }
    }
}
