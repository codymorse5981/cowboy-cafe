﻿/* Author: Cody Morse
 * Class: MainWindow.xaml.cs
 * Description: Handles MainWindow class for application (WPF)
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Swap the scren to an element
        /// </summary>
        /// <param name="elem">The element to swap to</param>
        public void SwapScreen(FrameworkElement elem)
        {
            Screen.Content = elem;
        }
    }
}
