namespace Golddigger
{
    using System;
    using System.Web;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.UI.WebControls;
    using Golddigger.App_Start;

    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DatabaseConfig.Initialize();

            // Create the custom role and user.
            RoleActions roleActions = new RoleActions();
            roleActions.AddUserAndRole();
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs.

            // Get last error from the server
            Exception exc = Server.GetLastError();

            if (exc is HttpUnhandledException)
            {
                if (exc.InnerException != null)
                {
                    exc = new Exception(exc.InnerException.Message);
                    Server.Transfer("ErrorPage.aspx?handler=Application_Error%20-%20Global.asax",
                        true);
                }
            }
        }
    }
}