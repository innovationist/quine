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
    public class SubmitModule : NancyModule
    {

        /**
         TODO:
           *Create new object of the Application Context class
           * Create a get request to warn users they should post to submit url
           * Post request to handle get new title and update the Title model
           * 
            
         */
        AppContext app = new AppContext();

        public SubmitModule() : base("/submit")
        {
    
                Get["/"] = _ =>
                {
                    var text = "You should send a post request (url: /submit/edit)";

                    return Response.AsJson(text);
                };


            Post["/edit"] = _ =>
            {
                // bind input to model.
                var title__ = this.Bind<Title>();

              
               // check if string is null or empty..

                if (String.IsNullOrEmpty(title__.Name))
                {
                    Debug.WriteLine("string is null");

                    //return Response.AsRedirect("/");

                    return Response.AsJson("string is null");

                }
                else
                {
                    // if string is not null, Update static repository with the new title

                    app.Edit(title__.Name);

                    return Response.AsJson("completed");
                }


            };

        }

    }
}