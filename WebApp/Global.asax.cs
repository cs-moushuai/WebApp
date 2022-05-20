using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application.Add("count", 0);

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["count"] = int.Parse(Application["count"].ToString()) + 1;
            Application.UnLock();

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
            Application.Lock();
            Application["count"] = int.Parse(Application["count"].ToString()) - 1;
            Application.UnLock();

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}