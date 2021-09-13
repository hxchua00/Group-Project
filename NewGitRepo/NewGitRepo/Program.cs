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
            string decision = Console.ReadLine().ToString();
            Console.WriteLine();

            bool shopping = true;
            while (shopping)
            {
                switch (decision)
                {
                    case "1":
                        Console.WriteLine("Welcome! What would you like to do?");
                        Console.WriteLine("1) Buy stuff");
                        Console.WriteLine("2) Find price of item");
                        Console.WriteLine("3) Find weight of item");
                        Console.WriteLine("4) Get total bill of shopping cart");
                        Console.WriteLine("5) Get total weight of shopping cart");
                        Console.WriteLine("6) Exit");
                        Console.WriteLine("----------------------------------------------------");
                        string newDecision = Console.ReadLine().ToString();
                        Console.WriteLine();

                        string itemName = "";
                        string itemPrice = "";
                        string itemWeight = "";

                        Item newItem = new Item();
                        Item[] itemArray = new Item[] { };
                        Bill toAdd = new Bill();

                        switch (newDecision)
                        {
                            case "1":
                                Console.WriteLine("Please enter name of item: ");
                                itemName = Console.ReadLine();
                                Console.WriteLine("Please enter price of " + itemName + " : ");
                                itemPrice = (Console.ReadLine()).ToString();
                                Console.WriteLine("Please enter weight of " + itemName + " : ");
                                itemWeight = (Console.ReadLine()).ToString();
                                Console.WriteLine();
                             
                                newItem = new Item(itemName, double.Parse(itemPrice), double.Parse(itemWeight));
                                //itemArray.Append(newItem);

                                for(int i=0; i < itemArray.Length; i++)
                                {
                                    if(itemArray[i] == null)
                                    {
                                        itemArray.Append(newItem);
                                        Console.WriteLine("Item have been added!" + itemArray[i]);
                                        Console.ReadLine();
                                    }
                                }
                                toAdd.addItems(newItem);
                                //testing
                                toAdd.printAll();
                                break;
                            case "2":
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

                                }
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                            case "6":
                                Console.WriteLine("Thank you for shopping with us!");
                                Console.ReadLine();
                                shopping = false;
                                break;
                            default:
                                Console.WriteLine();
                                break;

                        }

                        break;
                    case "2":
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
