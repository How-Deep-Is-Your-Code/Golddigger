namespace Golddigger.Services.Contracts
{
    using Models;
    using System.Linq;

    public interface IInterestService
    {
        IQueryable<Interest> All();

        Interest GetInterestById(int id);
    }
}