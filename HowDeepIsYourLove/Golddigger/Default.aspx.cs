namespace Golddigger
{
    using System.Collections.Generic;
    using System.Linq;
    using Golddigger.Models;
    using Golddigger.Services.Contracts;
    using Ninject;

    public partial class _Default : Ninject.Web.PageBase
    {
        [Inject]
        public IUsersService users { get; set; }

        public IQueryable<User> ListViewImages_GetGolddiggers()
        {
            return users.GetGolddiggerUsers();
        }

        public IQueryable<User> ListViewImages_GetSugardaddies()
        {
            return users.GetSugadaddyUsers();
        }

        public IQueryable<User> ListViewImages_GetSugarmammas()
        {
            return users.GetSugamammaUsers();
        }
    }
}