namespace Golddigger.Services
{
    using System.Linq;
    using Golddigger.Models;
    using Golddigger.Services.Contracts;
    using Data.Contracts;

    public class UsersService : IUsersService
    {
        private readonly IRepository<User> usersRepo;

        public UsersService(IRepository<User> usersRepo)
        {
            this.usersRepo = usersRepo;
        }

        public IQueryable<User> AllWithDeleted()
        {
            return this.usersRepo
                .All()
                .OrderBy(u => u.Id)
                .Where(u => u.UserInfo.AccountType != AccountType.Pimp);
        }
        public IQueryable<User> All()
        {
            return this.usersRepo
                .All()
                .OrderBy(u => u.Id)
                .Where(u => u.UserInfo.AccountType != AccountType.Pimp
                        && !u.IsDeleted);
        }

        public void Delete(string id)
        {
            this.usersRepo.Delete(id);
            this.usersRepo.SaveChanges();
        }

        public User GetById(string id)
        {
            return this.usersRepo.GetById(id);
        }

        public User GetByUserName(string userName)
        {
            return this.usersRepo
                .All()
                .FirstOrDefault(x => x.UserName == userName);
        }

        public IQueryable<User> GetGolddiggerUsers()
        {
            return this.usersRepo
                .All()
                .OrderBy(x=>x.Id)
                .Where(x => x.UserInfo.AccountType == AccountType.Golddigger
                && x.UserInfo.AccountType != AccountType.Pimp
                && !x.IsDeleted);
                

        }
        public IQueryable<User> GetSugadaddyUsers()
        {
            return this.usersRepo
                .All()
                .OrderBy(x => x.Id)
                .Where(x => x.UserInfo.AccountType == AccountType.Suggardaddy
                && x.UserInfo.AccountType != AccountType.Pimp
                && !x.IsDeleted);
        }

        public IQueryable<User> GetSugamammaUsers()
        {
            return this.usersRepo
                .All()
                .OrderBy(x => x.Id)
                .Where(x => x.UserInfo.AccountType == AccountType.Sugarmamma
                        && x.UserInfo.AccountType != AccountType.Pimp
                        && !x.IsDeleted);
        }

        public void Update()
        {
            this.usersRepo.SaveChanges();
        }
    }
}
