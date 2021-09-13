using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGitRepo
{
    class Item
    {
        public string name;
        public double weight;
        public double price;

        public Item()
        {
        }

        public Item(string name, double price, double weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        public string GetName()
        {
            return name;
        }
        public double GetPrice()
        {
            return price;
        }

        public double GetWeight()
        {
            return weight;
        }

    }
}
