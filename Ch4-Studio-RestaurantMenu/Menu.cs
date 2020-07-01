using System;
using System.Collections.Generic;
using System.Text;

namespace Ch4_Studio_RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Menu (List<MenuItem> menuItems, DateTime updatedDate)
        {
            MenuItems = menuItems;
            UpdatedDate = updatedDate;
        }

        // Add method 1): use loop and Equals method to check whether new item already exists in menu list,
        // then print a message, or add the item in.
        public void Add(MenuItem newItem)
        {
            foreach (MenuItem item in MenuItems)
            {
                if (newItem.Equals(item))
                {
                    Console.WriteLine("Item exists in the menu.");
                    return;
                }
            }
            MenuItems.Add(newItem);

        // Add method 2) use Contains method to check. Note: all fields should be same, then Contains() return "true".

            //if (MenuItems.Contains(newItem))
            //{
            //    Console.WriteLine("Item exists in the menu.");
            //}  
            //else
            //{
            //    MenuItems.Add(newItem);
            //}           
        }

        public void Remove(MenuItem itemToRemove)
        {
            MenuItems.Remove(itemToRemove);
        }

        public void PrintMenu(Menu menu)
        {
            Console.WriteLine("*******************\nMenu: ");
            foreach (MenuItem item in menu.MenuItems)
            {
                Console.WriteLine("***\n" + item + "\n");
            }
            Console.WriteLine("Last updated on " + UpdatedDate);
        }

        // How to use ToString to print out the whole menu? Can we print out a list in one command, not a loop?
        //public override string ToString()
        //{
        //    return "Menu: " + PrintMenuItems(MenuItems)+ "\nLast updated on " + UpdatedDate;
        //}
    }
}
