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
    /// Interaction logic for CrossoversWindow.xaml
    /// </summary>
    public partial class CrossoversWindow : Window
    {
        public CrossoversWindow()
        {
            InitializeComponent();
        }

        private void ChooseCrossovers_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("2021 C-HR", 21445));
            CrossoversEngineWindow newWindow = new CrossoversEngineWindow();
            this.Close();
            newWindow.ShowDialog();
        }

        private void ChooseHybrids_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("2021 Land Cruiser", 85415));
            CrossoversEngineWindow newWindow = new CrossoversEngineWindow();
            this.Close();
            newWindow.ShowDialog();
        }
    }
}
