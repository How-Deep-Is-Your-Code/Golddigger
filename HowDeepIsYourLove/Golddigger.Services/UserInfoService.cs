namespace Golddigger.Services
{
    using System;
    using Models;
    using Golddigger.Services.Contracts;
    using Data.Contracts;
    public class UserInfoService : IUserInfoService
    {
        private readonly IRepository<UserInfo> userInfoRepo;

        public UserInfoService(IRepository<UserInfo> userInfoRepo)
        {
            this.userInfoRepo = userInfoRepo;
        }

        public UserInfo GetUserInfoById(string id)
        {
            return this.userInfoRepo.GetById(id);
        }
    }
}