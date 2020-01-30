using System;
using System.Collections.Generic;

namespace Lab_3._2_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            bool addNewItem = false;
            bool tryAgain = false;
            List<string> shoppingKeyList = new List<string>();
            List<double> priceList = new List<double>();
            double itemPrice = 0.0;
            double sum = 0.0;
            Dictionary<string, double> inventory = new Dictionary<string, double>();

            do
            {
                inventory["apple"] = 1.25;
                inventory["banana"] = 3.02;
                inventory["cherry pie"] = 4.05;
                inventory["pumpkin wine"] = 9.54;
                inventory["tuna"] = 11.95;
                inventory["water"] = 100.06;
                inventory["patron"] = 11.94;
                inventory["beer"] = 7.95;

                Console.WriteLine("Welcome to the Most over priced shop. What would you like to purchase?\n");
                Console.WriteLine("Item:\t\tPrice:");
                foreach (KeyValuePair<string, double> item in inventory)
                {
                    Console.WriteLine($"{item.Key,-17}{item.Value,-15}");
                }
                Console.WriteLine();
                string userItem = Console.ReadLine().ToLower();

                if (inventory.ContainsKey(userItem))
                {
                    itemPrice = inventory[userItem];

                    shoppingKeyList.Add(userItem);
                    priceList.Add(itemPrice);
                    Console.WriteLine($"you added {userItem} at {itemPrice}");
                }
                else
                {
                    Console.WriteLine("Sorry this is not in our store");
                }


                do
                {
                    Console.WriteLine("Would you like to add another item? Yes or No");
                    string doAgainInput = Console.ReadLine().ToLower();

                    if ((doAgainInput == "yes") || (doAgainInput == "y"))
                    {
                        addNewItem = false;
                        tryAgain = true;
                        Console.Clear();
                        Console.WriteLine("Awesome!");


                    }
                    else if ((doAgainInput == "no") || (doAgainInput == "n"))
                    {
                        tryAgain = false;
                        addNewItem = false;
                        Console.Clear();
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("I am sorry. I did not understand that.");
                        addNewItem = true;
                    }
                } while (addNewItem == true);

            } while (tryAgain == true);


            Console.WriteLine("Here is your checkout list");
            Console.WriteLine("Item\t  Price\n");

            foreach (var item in shoppingKeyList)
            {                                   
                    Console.WriteLine($"{item,-8} {inventory[item],-1}");
            }

            foreach (var item in priceList)
            {
                sum += item;

            }

            double average = sum / priceList.Count;
            Console.WriteLine("================");
            Console.WriteLine($"Total:\t {sum,5}\n");
            Console.WriteLine($"Average price per item: {average}");


            
        }
    }
}
