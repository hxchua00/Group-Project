using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGitRepo
{
    public static class Extensions
    {
        public static T[] Append<T>(this T[] array, T item)
        {
            if (array == null)
            {
                return new T[] { item };
            }
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;

            return array;
        }
    }
    class Bill
    {
        Item[] ItemList = new Item[] { };

        public void addItems(Item newItem)
        {
            Item[] shopList = ItemList.Append(newItem);
        }

        public void printAll()
        {
            for(int i = 0; i < ItemList.Length; i++)
            {
                Console.WriteLine("Name of item "+ i + 1 + ": " + ItemList[i].GetName());
                Console.WriteLine("Price of item " + i + 1 + ": " + ItemList[i].GetPrice());
                Console.WriteLine("Weight of item " + i + 1 + ": " + ItemList[i].GetWeight());
                Console.WriteLine();
            }
        }
        public double GetFinalBill()
        {
            double totalBill=0;

            for(int i =0; i <ItemList.Length; i++)
            {
                totalBill += ItemList[i].GetPrice(); 
            }
            return totalBill;
        }
        public double GetTotalWeight()
        {
            double totalWeight = 0;
            for(int i=0; i < ItemList.Length; i++)
            {
                totalWeight += ItemList[i].GetWeight();
            }
            return totalWeight;
        }
    }
}
