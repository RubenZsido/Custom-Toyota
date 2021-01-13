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
            for (int i = 0; i < purchasableItems.Count; i++)
            {
                if (purchasableItems[i].name == item.name)
                {
                    purchasableItems[i].count++;
                    break;
                } 
            }
            purchasableItems.Add(item);
        }

        public static string GetOutput()
        {
            string output = "";
            for (int i = 0; i < purchasableItems.Count; i++)
            {
                output = output + purchasableItems[i].name + " x " + purchasableItems[i].count + " \t\t\t\t\t\t" + "$" + purchasableItems[i].price * purchasableItems[i].count + "\n\n";
            }
            int sum = 0;
            for (int i = 0; i < purchasableItems.Count; i++)
            {
                sum += purchasableItems[i].price * purchasableItems[i].count;
            }
            output = output + "-----------------------------------------------------------------------------------------------------\nTotal\t\t\t\t\t$" + sum;
            return output;
        }

        public static List< PurchasableItem> GetItems()
        {
            return purchasableItems;
        }
    }
}
