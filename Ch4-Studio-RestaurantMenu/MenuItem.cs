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

        //private bool isNew;

        public DateTime LastUpdatedDate { get; set; }

        public bool IsNew
        {
            get
            {
                //return isNew;
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

            //set
            //{
            //    //to check whether is new(if updated within 7 days, return true)
            //    var today = DateTime.Today;
            //    if (today <= lastUpdatedDate.AddDays(7))
            //    {
            //        isNew = true;
            //    }
            //    else
            //    {
            //        isNew = false;
            //    }
            //}
        }

        //isNew function to check whether is new(if updated within 7 days, return true)
        //public bool IsNew(DateTime lastUpdatedDate)
        //{
        //        var today = DateTime.Today;
        //        if (today <= lastUpdatedDate.AddDays(7))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //}




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
    }
}
