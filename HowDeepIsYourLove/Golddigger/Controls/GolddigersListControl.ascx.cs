namespace Golddigger.Controls
{
    using System.Linq;
    using Golddigger.Models;
    using Golddigger.Services.Contracts;
    using Ninject;

    public partial class GolddigersListControl : System.Web.UI.UserControl
    {
        [Inject]
        public IUsersService users { get; set; }

        public IQueryable<User> ListView_GetGolddiggers()
        {
            return this.users.GetGolddiggerUsers();
        }
    }
}