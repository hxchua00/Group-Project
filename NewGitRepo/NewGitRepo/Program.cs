using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGitRepo
{ 
    class Item
    {
        string name;
        double Weight;
        double Price;
        public double GetPrice() 
        {
            return Price;
        }

        public double GetWeight()
        {
            return Weight;
        }

    }

    class Bill
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Add a number of items
            //Call GetFinalBill()
            //GetTotalWeight()

            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
