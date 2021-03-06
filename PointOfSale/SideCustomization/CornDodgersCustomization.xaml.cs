﻿/* Author: Cody Morse
 * Class: CornDodgersCustomization.cs
 * Description: Handles CornDodgersCustomization class
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
    /// Interaction logic for CornDodgersCustomization.xaml
    /// </summary>
    public partial class CornDodgersCustomization : UserControl
    {
        public CornDodgersCustomization()
        {
            InitializeComponent();
        }

        private CornDodgers cornDodgers;
        public CornDodgersCustomization(CornDodgers c)
        {
            cornDodgers = c;
            InitializeComponent();
        }
    }
}
