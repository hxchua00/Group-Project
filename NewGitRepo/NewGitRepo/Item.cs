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
    }
}
