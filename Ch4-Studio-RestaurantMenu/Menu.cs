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

    }
}
