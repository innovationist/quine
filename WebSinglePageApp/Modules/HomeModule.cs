using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WebSinglePageApp.Models;

namespace WebSinglePageApp.Modules
{
    /**
         TODO:
           * Create a Nancy module
           * Create new object of the Application Context class
           * Get request to handle landing page (Home page)
           * Get request to RedIRECT ANY ODD URL TO HOME PAGE (FOR TESTING ONLY)
           * 
           * 
            
         */

    public class HomeModule : NancyModule
    {
        AppContext app = new AppContext();

        public HomeModule() : base("/")
        {
            Get["/"] = _ =>
            {
                // GET DATA FROM STATIC REPO
               var items = app.GetTitle();

                // RETURN VIEW WITH MODEL TO Razor
                return View["Index", items];
            };


            Get["/Home/Index"] = _ =>
            {
                var items = app.GetTitle();

                return Response.AsRedirect("/");
            };
   
        } 
        
    }
}