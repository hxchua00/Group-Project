using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGitRepo
{
    class Bill : Item
    {
        //ERROR STARTS HERE, somewhere....
        public Item[] ItemList;
        string[] itemArr = new string[3];


        public void addItems(Item newItem)
        {
            newItem = new Item(name, price, weight);
            itemArr[0] = newItem.name;
            itemArr[1] = (newItem.price).ToString();
            itemArr[2] = (newItem.weight).ToString();


            public void printAll()
            {
                Console.WriteLine();
            }
        }
            //Until here Error! T-T
            public double GetFinalBill()
            {
                double totalBill = 0;

                for (int i = 0; i < ItemList.Length; i++)
                {
                    totalBill += ItemList[i].GetPrice();
                }
                return totalBill;
            }
            public double GetTotalWeight()
            {
                double totalWeight = 0;
                for (int i = 0; i < ItemList.Length; i++)
                {
                    totalWeight += ItemList[i].GetWeight();
                }
                return totalWeight;
            }
    }
}
