﻿namespace Golddigger.Controls
{
    using System;
    using System.Linq;
    using Models;
    using Ninject;
    using Services.Contracts;
  
    public partial class UsersListControl : System.Web.UI.UserControl
    {
        protected System.Web.UI.WebControls.HyperLink AdminButton;

        [Inject]
        public IUsersService users { get; set; }

        public IQueryable<User> ListView_GetAllUsers()
        {
            return this.users.All();
        }
    }
}