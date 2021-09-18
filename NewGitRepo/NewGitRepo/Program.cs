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
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Option: ");
            int decision = int.Parse(Console.ReadLine());
            Console.WriteLine();

            bool shopping = true;
            while (shopping)
            {
                switch (decision)
                {
                    case 1:
                        Console.WriteLine("Welcome! What would you like to do?");
                        Console.WriteLine("1) Buy stuff");
                        Console.WriteLine("2) Find price of item");
                        Console.WriteLine("3) Find weight of item");
                        Console.WriteLine("4) Get total bill of shopping cart");
                        Console.WriteLine("5) Get total weight of shopping cart");
                        Console.WriteLine("6) Print shopping list");
                        Console.WriteLine("7) Exit");
                        Console.WriteLine("----------------------------------------------------");
                        int newDecision = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        string itemName = "";
                        string itemPrice = "";
                        string itemWeight = "";

                        Item newItem = new Item();
                        Bill newBill = new Bill();

                        switch (newDecision)
                        {
                            case 1:
                                Console.WriteLine("Please enter name of item: ");
                                itemName = Console.ReadLine();
                                Console.WriteLine("Please enter price of " + itemName + " : ");
                                itemPrice = (Console.ReadLine()).ToString();
                                Console.WriteLine("Please enter weight of " + itemName + " : ");
                                itemWeight = (Console.ReadLine()).ToString();
                                Console.WriteLine();
                             
                                //ERROR STARTS HERE T-T
                                newItem = new Item(itemName, double.Parse(itemPrice), double.Parse(itemWeight));
                                newBill.addItems(newItem);

                                Console.WriteLine("Item " + itemName + " have been added!");

                                //testing - Not printing anything :(
                                newBill.printAll();
                                break;
                            case 2:
                                Console.WriteLine("Finding item price...");
                                Console.WriteLine("Enter name of item: ");
                                string sName = (Console.ReadLine()).ToString();

                                if (sName == "")
                                {
                                    Console.WriteLine("Do not leave this field Empty!");
                                    Console.ReadLine();
                                    break;
                                }
                                else if (sName == itemName)
                                {
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                double totalWeight = 0;
                                foreach(Item x in newBill.ItemList)
                                {
                                    totalWeight += x.GetWeight();
                                }
                                Console.WriteLine("Total Weight of your shopping is: " + totalWeight + " grams.");
                                Console.ReadLine();
                                break;
                            case 6:
                                newBill.printAll();
                                Console.ReadLine();
                     
                                break;
                            case 7:
                                Console.WriteLine("Thank you for shopping with us!");
                                Console.ReadLine();
                                shopping = false;
                                break;
                            default:
                                Console.WriteLine();
                                break;

                        }

                        break;
                    case 2:
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                        shopping = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option! We shall now close! Good bye!");
                        shopping = false;
                        break;
                }
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
