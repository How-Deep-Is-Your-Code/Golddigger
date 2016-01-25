namespace Golddigger.Account
{
    using System;
    using System.Web.UI;
    using Golddigger.Models;
    using Ninject;
    using Golddigger.Services.Contracts;
    using Microsoft.AspNet.Identity;

    public partial class Profile : Ninject.Web.PageBase
    {
        [Inject]
        public IUsersService users { get; set; }

        protected User CurrentUser { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!this.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/");
            }

            if (!Page.IsPostBack)
            {
                var userId = this.User.Identity.GetUserId();
                this.CurrentUser = users.GetById(userId);
            }
        }
    }
}