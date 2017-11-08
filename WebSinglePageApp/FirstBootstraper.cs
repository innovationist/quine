using Nancy;
using Nancy.Bootstrapper;
using Nancy.Conventions;
using Nancy.Session;
using Nancy.TinyIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSinglePageApp
{
    public class FirstBootstraper : DefaultNancyBootstrapper
    {

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            
            CookieBasedSessions.Enable(pipelines);
           
            StaticConfiguration.DisableErrorTraces = false;
        }


        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
        }

        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);
            conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts"));
            conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Contents"));

        }

    }
}