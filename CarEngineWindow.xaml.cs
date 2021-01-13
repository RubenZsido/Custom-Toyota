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
    /// Interaction logic for CarEngineWindow.xaml
    /// </summary>
    public partial class CarEngineWindow : Window
    {
        public CarEngineWindow()
        {
            InitializeComponent();
        }

        private void ChooseCrossovers_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("2.0-Liter 4-Cylinder with FWD (iMT)", 3000));
            Accessories newWindow = new Accessories();
            this.Close();
            newWindow.ShowDialog();
        }

        private void ChooseHybrids_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("2.0-Liter 4-Cylinder with FWD (iMT)", 5000));
            Accessories newWindow = new Accessories();
            this.Close();
            newWindow.ShowDialog();
        }
    }
}
