namespace Golddigger.Admin
{
    using System;
    using Ninject;
    using Services.Contracts;
    using System.Linq;
    using Models;
    public partial class AdminHome : System.Web.UI.Page
    {
        [Inject]
        public IUsersService users { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IQueryable<User> GridViewAll_GetData()
        {
            return users.All();
        }
    }
}