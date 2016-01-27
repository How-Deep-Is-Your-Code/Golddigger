namespace Golddigger.Controls
{
    using System.Linq;
    using Golddigger.Models;
    using Golddigger.Services.Contracts;
    using Ninject;

    public partial class SugardaddiesListControl : System.Web.UI.UserControl
    {
        [Inject]
        public IUsersService users { get; set; }

        public IQueryable<User> ListView_GetSugardaddies()
        {
            return this.users.GetSugadaddyUsers();
        }
    }
}