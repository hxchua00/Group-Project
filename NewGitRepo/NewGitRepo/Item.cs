using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGitRepo
{
    public class Item
    {
        public string name { get; set; }
        public double price { get; set; } //Price is per KG
        public double weight { get; set; } //Weight is in KG

        public Item() { }

        public Item(string name, double price, double weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        Bill bill = new Bill();
        public double getPrice(string name)
        {
            double Priceitem = 0;
            for (int i = 0; i < bill.ItemList.Length; i++)
            {
                if (Equals(bill.ItemList[i], name))
                {
                    Priceitem = bill.ItemList[i].price * bill.ItemList[i].weight;
                }
            }
            return Priceitem;
        }

        public double getWeight(string name)
        {
            for (int i = 0; i < bill.ItemList.Length; i++)
            {
                if (Equals(bill.ItemList[i], name))
                {
                    price = bill.ItemList[i].weight;
                }
            }
            return weight;
        }
    }
}
