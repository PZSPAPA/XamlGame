﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace XamlGame
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

        private void ButtonYes_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Igen gombot nyomtunk");
        }

        private void ButtonNo_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Nem gombot nyomtunk");
        }
    }
}
