using Golddigger.Models;
namespace Golddigger.Users
{
    using System.Linq;
    using Golddigger.Services.Contracts;
    using Ninject;

    public partial class AllSugarmammas : System.Web.UI.Page
    {
        [Inject]
        public IUsersService users { get; set; }

        public IQueryable<User> ListView_GetSugarmammas()
        {
            return this.users.GetSugadaddyUsers();
        }
    }
}