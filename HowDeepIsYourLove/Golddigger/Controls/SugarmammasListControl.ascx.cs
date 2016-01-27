namespace Golddigger.Controls
{
    using System.Linq;
    using Golddigger.Models;
    using Golddigger.Services.Contracts;
    using Ninject;

    public partial class SugarmammasListControl : System.Web.UI.UserControl
    {
        [Inject]
        public IUsersService users { get; set; }

        public IQueryable<User> ListView_GetSugarmammas()
        {
            return this.users.GetSugamammaUsers();
        }
    }
}