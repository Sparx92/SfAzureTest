using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Data.Configuration;
using Telerik.Sitefinity.Configuration;

namespace AzureTestNuget
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Bootstrapper.Bootstrapped += this.OnBootstrapped;
        }

        private void OnBootstrapped(object sender, EventArgs e)
        {
            IConnectionStringSettings connectionStringSettings = null ;

            DataConfig dataConfig = Config.Get<DataConfig>();
            bool success = dataConfig.TryGetConnectionString("Sitefinity", out connectionStringSettings);
        }

        public void GetConnectionString()
        {
            IConnectionStringSettings connectionStringSettings = null;

            DataConfig dataConfig = Config.Get<DataConfig>();
            bool success = dataConfig.TryGetConnectionString("Sitefinity", out connectionStringSettings);
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