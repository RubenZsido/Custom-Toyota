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
    /// Interaction logic for TrucksEngineWindow.xaml
    /// </summary>
    public partial class TrucksEngineWindow : Window
    {
        public TrucksEngineWindow()
        {
            InitializeComponent();
        }

        private void ChooseCrossovers_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("3.5L V6 Engine with 2WD", 2000));
            Accessories newWindow = new Accessories();
            this.Close();
            newWindow.ShowDialog();
        }

        private void ChooseHybrids_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("3.5L V6 Engine with 4WD", 5000));
            Accessories newWindow = new Accessories();
            this.Close();
            newWindow.ShowDialog();
        }
    }
}
