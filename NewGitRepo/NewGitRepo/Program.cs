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
            Item newItem = new Item();
            Bill newBill = new Bill();
            //Things to shop
            Item watermelon = new Item("Watermelon", 2.00, 10.2);
            Item chocolate = new Item("Chocolate", 15.00, 0.1);
            Item salmon = new Item("Salmon", 20.00, 5.6);

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
                        Console.WriteLine("========================================");
                        Console.WriteLine();
                        Console.WriteLine("1) Buy stuff");
                        Console.WriteLine("2) Find price of item");
                        Console.WriteLine("3) Find weight of item");
                        Console.WriteLine("4) Get total bill of shopping cart");
                        Console.WriteLine("5) Get total weight of shopping cart");
                        Console.WriteLine("6) Print shopping list");
                        Console.WriteLine("7) Exit");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine();
                        int newDecision = int.Parse(Console.ReadLine());

                        switch (newDecision)
                        {
                            //Buy items
                            case 1:
                                bool buyMenu = true;

                                while (buyMenu)
                                {
                                    Console.WriteLine("1) Watermelon");
                                    Console.WriteLine("2) Chocolate");
                                    Console.WriteLine("3) Salmon");
                                    Console.WriteLine("4) Nothing");
                                    Console.WriteLine();

                                    int selection = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Please choose which item you wish to buy: ");
                                    Console.WriteLine("==========================================");

                                    switch (selection)
                                    {
                                        case 1:
                                            newBill.AddItem(watermelon);
                                            Console.WriteLine("Great Choice! Watermelon is added to your shopping cart!");
                                            break;
                                        case 2:
                                            newBill.AddItem(chocolate);
                                            Console.WriteLine("Mmm delicious! Chocolate is added to your shopping cart!");
                                            break;
                                        case 3:
                                            newBill.AddItem(salmon);
                                            Console.WriteLine("Taste of the ocean! Salmon is added to your shopping cart!");
                                            break;
                                        case 4:
                                            Console.WriteLine("Please come again!");
                                            buyMenu = false;
                                            break;
                                        default:
                                            Console.WriteLine("Please choose from available option!");
                                            break;
                                    }
                                }

                                break;

                            //Find price of item
                            case 2:
                                Console.WriteLine("Finding item price...");
                                Console.WriteLine("Enter name of item: ");
                                string sName = (Console.ReadLine()).ToString();

                                Console.WriteLine(newItem.getPrice(sName));
                                //if (sName == "")
                                //{
                                //    Console.WriteLine("Do not leave this field Empty!");
                                //    Console.ReadLine();
                                //    break;
                                //}
                                //else if (sName == itemName)
                                //{
                                //    Console.WriteLine();
                                //}
                                break;

                            //Find weight of item
                            case 3:
                                Console.WriteLine("Finding item weight...");
                                Console.WriteLine("Enter name of item: ");
                                string wName = (Console.ReadLine()).ToString();

                                Console.WriteLine(newItem.getWeight(wName));
                                break;

                            //Get total price of shopping cart
                            case 4:
                                newBill.getFinalBill();
                                break;

                            //Get total weight of shopping cart
                            case 5:
                                newBill.getFinalWeight();
                                //double totalWeight = 0;
                                //foreach(Item x in newBill.ItemList)
                                //{
                                //    totalWeight += x.GetWeight();
                                //}
                                //Console.WriteLine("Total Weight of your shopping is: " + totalWeight + " grams.");
                                //Console.ReadLine();
                                break;

                            //Print everything within the shopping cart
                            case 6:
                                newBill.printAll();
                                Console.ReadLine();
                     
                                break;

                            //Exit
                            case 7:
                                Console.WriteLine("Thank you for shopping with us!");
                                Console.ReadLine();
                                shopping = false;
                                break;
                            default:
                                Console.WriteLine("Please sselect from available options only!");
                                break;

                        }

                        break;

                    //Exit
                    case 2:
                        Console.WriteLine("Thank you for using out system! Goodbye!");
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
