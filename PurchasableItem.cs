using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toyota
{
    public class PurchasableItem
    {
        public string name;
        public int price;
        public int count;

        public PurchasableItem(string _name, int _price)
        {
            name = _name;
            price = _price;
            count = 1;

        }
    }
}
