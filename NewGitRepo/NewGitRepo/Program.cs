using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGitRepo
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Add a number of items
            Console.WriteLine("Hello! Welcome to shopping with us!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Shopping");
            Console.WriteLine("2) Nothing");
            string decision = Console.ReadLine().ToString();

            switch (decision)
            {
                case "1":
                    Console.WriteLine("Welcome! What would you like to do?");
                    Console.WriteLine("1) Buy stuff");
                    Console.WriteLine("2) Find price of item");
                    Console.WriteLine("3) Find weight of item");
                    Console.WriteLine("4) Get total bill of shopping cart");
                    Console.WriteLine("5) Get total weight of shopping cart");
                    string newDecision = Console.ReadLine().ToString();

                    switch(newDecision){
                        case "1":
                            Console.WriteLine("Please enter name of item: ");
                            string itemName = Console.ReadLine();
                            Console.WriteLine("Please enter price of " + itemName + " : ");
                            string itemPrice = (Console.ReadLine()).ToString();
                            Console.WriteLine("Please enter weight of " + itemName + " : ");
                            string itemWeight = (Console.ReadLine()).ToString();

                            Item newItem = new Item();
                            Bill toAdd = new Bill();
                            newItem = new Item(itemName, double.Parse(itemPrice),double.Parse(itemWeight));
                            toAdd.addItems(newItem);
                            //testing
                            toAdd.printAll();
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        default:
                            Console.WriteLine();
                            break;

                    }

                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Invalid option! We shall now close! Good bye!");
                    break;
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
