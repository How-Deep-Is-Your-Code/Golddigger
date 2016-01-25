namespace Golddigger.Services.Contracts
{
    using Models;

    public interface IUserInfoService
    {
        UserInfo GetUserInfoById(string id);
    }
}