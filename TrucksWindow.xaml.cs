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
    /// Interaction logic for TrucksWindow.xaml
    /// </summary>
    public partial class TrucksWindow : Window
    {
        public TrucksWindow()
        {
            InitializeComponent();
        }

        private void ChooseCrossovers_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Tacoma", 26150));
            TrucksEngineWindow newWindow = new TrucksEngineWindow();
            this.Close();
            newWindow.ShowDialog();
        }

        private void ChooseHybrids_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("Tundra", 33675));
            TrucksEngineWindow newWindow = new TrucksEngineWindow();
            this.Close();
            newWindow.ShowDialog();
        }
    }
}
