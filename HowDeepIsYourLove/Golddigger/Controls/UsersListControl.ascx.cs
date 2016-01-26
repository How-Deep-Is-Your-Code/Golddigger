namespace Golddigger.Controls
{
    using System;
    using System.Linq;
    using Models;
    using Ninject;
    using Services.Contracts;
  
    public partial class UsersListControl : System.Web.UI.UserControl
    {
        [Inject]
        public IUsersService users { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IQueryable<User> ListView_GetAllUsers()
        {
            return this.users.All();
        }
    }
}