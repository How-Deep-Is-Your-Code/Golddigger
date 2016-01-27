namespace Golddigger.Services.Contracts
{
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    public interface IUsersService
    {
        IQueryable<User> All();

        IQueryable<User> AllWithDeleted();

        IQueryable<User> GetGolddiggerUsers();

        IQueryable<User> GetSugadaddyUsers();

        IQueryable<User> GetSugamammaUsers();

        User GetById(string id);

        User GetByUserName(string userName);

        void Update();

        void Delete(string id);
    }
}
