namespace Golddigger.Services.Contracts
{
    using Golddigger.Models;
    using System.Linq;

    public interface ICountriesService
    {
        IQueryable<Country> All();
    }
}