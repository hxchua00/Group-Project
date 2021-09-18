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

        public void addItems(Item newItem)
        {
            newItem = new Item(name,price,weight);
            ItemList.Append(newItem);
        }

        public void printAll()
        {

        }
        //Until here Error! T-T
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
