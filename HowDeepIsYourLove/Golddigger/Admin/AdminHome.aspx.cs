namespace Golddigger.Admin
{
    using System;
    using System.Linq;
    using Models;
    using Ninject;
    using Services.Contracts;

    public partial class AdminHome : System.Web.UI.Page
    {
        [Inject]
        public IUsersService users { get; set; }

        public IQueryable<User> GridViewUsers_GetData()
        {
            return this.users.AllWithDeleted();
        }

        public void GridViewUsers_UpdateItem(string id)
        {
            User user = this.users.GetById(id);

            if (user == null)
            {
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            this.TryUpdateModel(user);

            if (ModelState.IsValid)
            {
                this.users.Update();
            }
        }

        public void GridViewUsers_DeleteItem(string id)
        {
            User user = this.users.GetById(id);

            if (user == null)
            {
                ModelState.AddModelError("", string.Format("Item with id {0} was not found", id));
                return;
            }

            this.TryUpdateModel(user);

            if (ModelState.IsValid)
            {
                var userTarget = this.users.GetById(id);
                userTarget.IsDeleted = true;
                this.users.Update();
            }
        }
    }
}