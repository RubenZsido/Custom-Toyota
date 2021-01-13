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
    /// Interaction logic for HybridsWindow.xaml
    /// </summary>
    public partial class HybridsWindow : Window
    {
        public HybridsWindow()
        {
            InitializeComponent();
        }

        private void ChooseHybrids_Click(object sender, RoutedEventArgs e)
        {
            //mirai
            Router.AddItem(new PurchasableItem("Mira", 49500));
            CarEngineWindow newWindow = new CarEngineWindow();
            this.Close();
            newWindow.ShowDialog();
        }

        private void ChooseTrucks_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Corolla", 19925));
            CarEngineWindow newWindow = new CarEngineWindow();
            this.Close();
            newWindow.ShowDialog();
        }

        private void ChooseCrossovers_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Prius Prime", 28220));
            CarEngineWindow newWindow = new CarEngineWindow();
            this.Close();
            newWindow.ShowDialog();
        }
    }
}
