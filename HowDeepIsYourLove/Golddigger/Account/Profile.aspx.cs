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

        public List<Interest> Interests { get; set; }

        protected User CurrentUser { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string userId = this.Request.QueryString["id"];
            this.CurrentUser = users.GetById(userId);
            

            if(this.CurrentUser.UserInfo != null)
            {
                Interests = this.CurrentUser.UserInfo.Interests.ToList();
            }

            this.UserInterests.DataSource = Interests;
            this.UserInterests.DataBind();

            if (!this.User.Identity.IsAuthenticated)
            {
                throw new UnauthorizedAccessException("Unauthorized access! You need to log in to view profile details!");
            }

            if (!Page.IsPostBack)
            {
                ListViewComments_GetData();
            }
        }
        private void Page_Error(object sender, EventArgs e)
        {
            // Get last error from the server.
            Exception exc = Server.GetLastError();

            if(exc is UnauthorizedAccessException)
            {
                Server.Transfer("ErrorPage.aspx?handler=403%20-%20Default.aspx",
                    true);
            }

            // Handle specific exception.
            if (exc is InvalidOperationException)
            {
                // Pass the error on to the error page.
                Server.Transfer("ErrorPage.aspx?handler=Page_Error%20-%20Default.aspx",
                    true);
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