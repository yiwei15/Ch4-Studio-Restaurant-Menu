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

            Console.WriteLine(menu1.MenuItems[0].Name + " is new: " + menu1.MenuItems[0].IsNew);
            Console.WriteLine("menue updated at: " + menu1.UpdatedDate);
            Console.WriteLine(menu1.MenuItems[1].Name + " is new: " + menu1.MenuItems[1].IsNew);

        }
    }
}
