namespace Golddigger.Account
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;
    using Golddigger.Models;
    using Ninject;
    using Golddigger.Services.Contracts;
    using Microsoft.AspNet.Identity;
    using System.Linq;
    public partial class Profile : Ninject.Web.PageBase
    {
        [Inject]
        public IUsersService users { get; set; }

        [Inject]
        public ICommentsService comments { get; set; }

        protected User CurrentUser { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var userId = this.User.Identity.GetUserId();
            this.CurrentUser = users.GetById(userId);
            var interests = this.CurrentUser.UserInfo.Interests;
            this.UserInterests.DataSource = interests;
            this.UserInterests.DataBind();

            if (!this.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/");
            }

            if (!Page.IsPostBack)
            {
                ListViewComments_GetData();
            }
        }

        public IQueryable ListViewComments_GetData()
        {
            string userId = this.Request.QueryString["id"];
            return this.comments.AllReceivedByUser(userId);
        }

        public User ListViewUser_GetData()
        {
            string userId = this.Request.QueryString["id"];
            return this.users.GetById(userId);
        }
        protected void AddComment_Click(object sender, EventArgs e)
        {
            string userFromId = this.User.Identity.GetUserId();
            string userToId = this.Request.QueryString["id"];
            string content = this.CommentInput.Text;
            this.comments.Add(userFromId, userToId, content);
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
}