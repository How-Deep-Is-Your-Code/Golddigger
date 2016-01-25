namespace Golddigger.Account
{
    using System;
    using System.Web.UI;
    using Golddigger.Models;
    using Ninject;
    using Golddigger.Services.Contracts;
    using Microsoft.AspNet.Identity;
    using System.Collections.Generic;
    public partial class Profile : Page
    {
        [Inject]
        public IUsersService users { get; set; }

        protected User CurrentUser { get; set; }

        public Profile()
        {
            var kernel = App_Start.NinjectWebCommon.CreateKernel();
            users = kernel.Get<IUsersService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/");
            }

            if (!Page.IsPostBack && this.User.Identity.IsAuthenticated)
            {
                var userId = this.User.Identity.GetUserId();
                this.CurrentUser = users.GetById(userId);
            }
        }
    }
}