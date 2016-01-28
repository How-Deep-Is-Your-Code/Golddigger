namespace Golddigger
{
    using System.Linq;
    using Golddigger.Models;
    using Golddigger.Services.Contracts;
    using Ninject;
    using System;
    public partial class _Default : Ninject.Web.PageBase
    {
        [Inject]
        public IUsersService users { get; set; }

        public IQueryable<User> ListViewImages_GetGolddiggers()
        {
            return users.GetGolddiggerUsers().Take(10);
        }

        public IQueryable<User> ListViewImages_GetSugardaddies()
        {
            return users.GetSugadaddyUsers().Take(10);
        }

        public IQueryable<User> ListViewImages_GetSugarmammas()
        {
            return users.GetSugamammaUsers().Take(10);
        }
    }
}