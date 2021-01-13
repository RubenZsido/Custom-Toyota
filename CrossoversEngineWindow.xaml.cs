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
    /// Interaction logic for CrossoversEngineWindow.xaml
    /// </summary>
    public partial class CrossoversEngineWindow : Window
    {
        public CrossoversEngineWindow()
        {
            InitializeComponent();
        }

       

        private void ChooseHybrids_Click(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("2.0L 4-Cyl. CVTi-S with FWD", 4000));
            Accessories newWindow = new Accessories();
            this.Close();
            newWindow.ShowDialog();
        }

        private void ChooseCrossovers_Click_1(object sender, RoutedEventArgs e)
        {
            Router.AddItem(new PurchasableItem("5.7L V8 Engine with 4WD", 2000));
            Accessories newWindow = new Accessories();
            this.Close();
            newWindow.ShowDialog();
        }
    }
}
