using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create 2 classes, store 1 class object in the other class
namespace NewGitRepo
{
    public class Bill
    {
        public Item[] ItemList = new Item[1];
        int i = 0;

        public void AddItem(Item item)
        {
            ItemList[i] = new Item();

            if (ItemList[i] != null)
            {

                ItemList[i].name = item.name;
                ItemList[i].price = item.price;
                ItemList[i].weight = item.weight;

                //Console.WriteLine("Current Array size is: " + ItemList.Length);
            }
            Array.Resize(ref ItemList, ItemList.Length + 1);
            i++;
        }

        public void printAll()
        {
            Console.WriteLine("Shopping Cart");
            Console.WriteLine("==========================");
            foreach (var Member in ItemList)
            {
                if (Member != null)
                {
                    Console.WriteLine("Item Name:{0}", Member.name);
                    Console.WriteLine("Item Price:{0}", Member.price);
                    Console.WriteLine("Item Weight:{0}", Member.weight);
                    Console.WriteLine("---------------------------");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("That's everything in the cart!");
                    break;
                }

            }
        }
    }
}
