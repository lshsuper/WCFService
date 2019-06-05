using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Autofac;
using Autofac.Integration.Wcf;

namespace OrderServer
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();
         
            var repository = Assembly.Load("WCFService.Repository").GetTypes().Where(o => o.Name.EndsWith("Repository")).ToArray();
            builder.RegisterTypes(repository).AsImplementedInterfaces();
            var services = Assembly.Load("WCFService.Application").GetTypes().Where(o => o.Name.EndsWith("Service")).ToArray();
            builder.RegisterTypes(services).AsImplementedInterfaces();
            var container=builder.Build();
            AutofacHostFactory.Container = container;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}