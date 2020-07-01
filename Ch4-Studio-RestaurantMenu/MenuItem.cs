using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection.Emit;
using System.Text;

namespace Ch4_Studio_RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Descripiton { get; set; }
        public string Category { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool IsNew
        {
            get
            {
                //to check whether is new(if updated within 7 days, return true)
                var today = DateTime.Today;
                if (today <= LastUpdatedDate.AddDays(7))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //Constructor to creat new MenuItem
        public MenuItem(string name, double price, string description, string category, DateTime lastUpdatedDate)
        {
            Name = name;
            Price = price;
            Descripiton = description;
            Category = category;
            LastUpdatedDate = lastUpdatedDate;
            //IsNew = isNew;
        }

        public override string ToString()
        {
            return Name + ": \n" + IsNew + "\n" + Price + "\n" + Category + "\n" + Descripiton;
        }

        public override bool Equals(object obj)
        {
            MenuItem toBeCompared = obj as MenuItem;
            if (toBeCompared.Name == Name || toBeCompared.Descripiton == Descripiton)
            {
                return true;
            }   
            else
            {
                return false;
            }
        }
    }
}
