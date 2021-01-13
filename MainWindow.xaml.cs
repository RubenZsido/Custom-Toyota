﻿using System;
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

namespace Toyota
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            
        }

        private void ChooseCrossovers_Click(object sender, RoutedEventArgs e)
        {
            CrossoversWindow newWindow = new CrossoversWindow();
            this.Close();
            newWindow.ShowDialog();
            
        }

        private void ChooseTrucks_Click(object sender, RoutedEventArgs e)
        {
            TrucksWindow newWindow = new TrucksWindow();
            this.Close();
            newWindow.ShowDialog();
        }

        private void ChooseHybrids_Click(object sender, RoutedEventArgs e)
        {
            HybridsWindow newWindow = new HybridsWindow();
            this.Close();
            newWindow.ShowDialog();
        }


        /* private void Window_Initialized(object sender, EventArgs e)
         {
             Router.ParentPanel = asd;
             asd.Children.Clear();
             asd.Children.Add(new Test());
         }*/
    }
}
