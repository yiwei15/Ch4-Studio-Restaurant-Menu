using System;
using System.Collections.Generic;

namespace Ch4_Studio_RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

           // public DateTime lastUpdateDate = new DateTime(2020, 6, 20, 0, 0, 0);

            MenuItem item1 = new MenuItem("Shrimp Scampi Fritta", 10.49, "Lightly breaded, fried and tossed in our signature scampi sauce.", "Appetizer", new DateTime(2020, 6, 25, 0, 0, 0));
            MenuItem item2 = new MenuItem("Chicken Alfredo", 17.29, "Not everyone knows our signature alfredo sauce is made from scratch daily. This homemade sauce combines simple, fresh ingredients like butter, cream and parmesan cheese to make a rich topping to our fettuccine pasta. Then it is topped with tender, sliced grilled chicken. Sprinkle some parsley flakes on top and buon appetito! Olive Garden's classic Chicken Alfredo is an easy and delicious choice for dinner.", "Entree", new DateTime(2020, 5, 21, 0, 0, 0));


            List<MenuItem> itemList = new List<MenuItem>();
            itemList.Add(item1);
            itemList.Add(item2);

            DateTime updatedDate = new DateTime(2020, 6, 20, 0, 0, 0);
            //Console.WriteLine(updatedDate);

            Menu menu1 = new Menu(itemList, updatedDate);

            //Console.WriteLine(menu1.MenuItems[0].Name + " is new: " + menu1.MenuItems[0].IsNew);
            //Console.WriteLine("menu updated at: " + menu1.UpdatedDate);
            //Console.WriteLine(menu1.MenuItems[1].Name + " is new: " + menu1.MenuItems[1].IsNew);

            //Add one menu item:
            MenuItem newItem = new MenuItem("Tiramisu", 7.29, "The classic Italian dessert. A layer of creamy custard set atop espresso-soaked ladyfingers.", "Dessert", DateTime.Today);
            menu1.Add(newItem);

            //Remove one menu item:
            menu1.Remove(newItem);

            //Tell if a menu item is new:
            Console.WriteLine("******* if a menu item is new *******");
            Console.WriteLine(menu1.MenuItems[1].IsNew);

            //Tell when the menu was last updated
            Console.WriteLine("******* last updated date *******");
            Console.WriteLine(menu1.UpdatedDate);

            //Print out a single menu item, what is the different between below two statements?
            Console.WriteLine(item1.ToString());
            Console.WriteLine(item2);

            //Print out the entire menu
            menu1.PrintMenu(menu1);

            //Whether or not two menu items are equal
            Console.WriteLine(item1.Equals(item2));
            MenuItem item3 = item1;
            Console.WriteLine(item1.Equals(item3));
            MenuItem item4 = new MenuItem("Copy of Shrimp Scampi Fritta", 10.49, "Lightly breaded, fried and tossed in our signature scampi sauce.", "Dessert", new DateTime(2010, 6, 25, 0, 0, 0));
            Console.WriteLine(item1.Equals(item4));

            //Bonus:  if a user tries to add an item that is already on the menu

            MenuItem item5 = new MenuItem("Shrimp Scampi Fritta", 20.49, "Lightly breaded, fried and tossed in our signature scampi sauce.", "Appetizer", new DateTime(2020, 6, 25, 0, 0, 0));
            menu1.Add(item5);
            menu1.PrintMenu(menu1);
        
        }
    }
}
