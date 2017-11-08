using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebSinglePageApp.Models
{
    public class AppContext
    {
        /*
         TODO:
         *Create a list to hold the value of our Model..
         * Create a constructor and assign new value to the lists
         * create a method to return list of Titles
         * Create a void method to update list of titles
         */


          // declaring variables
        private static readonly List<Title> titles = new List<Title>();
       
        
        static AppContext()
        {
            // add new title item to list
            titles.Add(new Title {

                Id = 1,
                Name = "Title" 

            });
        }

        
        public List<Title> GetTitle()
        {
            // returns list to 
            return titles;
        }

        public void Edit( string str)
        {
            // Edit the list item (GET ID AND SET OLD TITLE TO NEW TITLE)
            var name_ = titles.Where(t => t.Id == 1).FirstOrDefault();

            if(name_ != null)
            {
                name_.Name = str;
            }

        }

      
    }
}