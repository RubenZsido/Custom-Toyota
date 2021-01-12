using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Toyota
{
    public static class Router
    {
        public static StackPanel ParentPanel;

        private static List<PurchasableItem> purchasableItems = new List<PurchasableItem>();

        public static void AddItem(PurchasableItem item)
        {
            purchasableItems.Add(item);
        }

        public static List< PurchasableItem> GetItems()
        {
            return purchasableItems;
        }
    }
}
