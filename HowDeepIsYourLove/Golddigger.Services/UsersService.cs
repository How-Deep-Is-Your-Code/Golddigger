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

        public IQueryable<User> All()
        {
            return this.usersRepo.All().OrderBy(u => u.Id);
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
            return this.usersRepo.All().FirstOrDefault(x => x.UserName == userName);
        }

        public IQueryable<User> GetGolddiggerUsers()
        {
            return this.usersRepo
                .All()
                .Where(x => x.UserInfo.AccountType == AccountType.Golddigger
                && x.UserInfo.AccountType != AccountType.Pimp);
                

        }
        public IQueryable<User> GetSugadaddyUsers()
        {
            return this.usersRepo
                .All()
                .Where(x => x.UserInfo.AccountType == AccountType.Suggardaddy
                && x.UserInfo.AccountType != AccountType.Pimp);
        }

        public IQueryable<User> GetSugamammaUsers()
        {
            return this.usersRepo
                .All()
                .Where(x => x.UserInfo.AccountType == AccountType.Sugarmamma
                        && x.UserInfo.AccountType != AccountType.Pimp);
        }

        public void Update()
        {
            this.usersRepo.SaveChanges();
        }
    }
}
