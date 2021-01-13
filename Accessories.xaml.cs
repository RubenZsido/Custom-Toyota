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
using System.Windows.Shapes;

namespace Toyota
{
    /// <summary>
    /// Interaction logic for Accessories.xaml
    /// </summary>
    public partial class Accessories : Window
    {
        public Accessories()
        {
            InitializeComponent();
        }

        private void AddtoCart_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Alloy wheel locks", 20));
            //removed
            //removed
            //removed
        }

        private void AddtoCart_Copy_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("All-Weather Floor Liner Package", 20));
            //removed
            //removed
            //removed

        }

        private void AddtoCart_Copy1_Click(object sender, RoutedEventArgs e)
        {
           
            Router.AddItem(new PurchasableItem("All - Weather Floor Liners", 20));
            //removed
            //removed
            //removed
        }

        private void AddtoCart1_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Cargo Tote", 20));
            //removed
            //removed
            //removed
        }

        private void AddtoCart_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Carpet Floor Mats", 20));
            //removed
            //removed
            //removed
        }

        private void AddtoCart_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Emergency Assistance Kit", 33));
            //removed
            //removed
            //removed
        }

        private void AddtoCart2_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Four Season Floor Mat", 33));
            //removed
            //removed
            //removed
        }

        private void AddtoCart_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("TrailBall", 33));
            //removed
            //removed
            //removed
        }

        private void AddtoCart_Copy5_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Lowering Springs", 33));
            //removed
            //removed
            //removed
        }

        private void AddtoCart3_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Oil Filter", 33));
            //removed
            //removed
            //removed
        }

        private void AddtoCart_Copy6_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("UniversalTabletHolder", 33));
            //removed
            //removed
            //removed
        }

        private void AddtoCart_Copy7_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Security System", 33));
            //removed
            //removed
            //removed
        }

        private void AddtoCart_Copy9_Click(object sender, RoutedEventArgs e)
        {
            CartWindow newWindow = new CartWindow();
            this.Close();
            newWindow.ShowDialog();
        }
    }
}
