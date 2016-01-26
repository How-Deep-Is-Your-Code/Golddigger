namespace Golddigger.Services.Contracts
{
    using Golddigger.Models;
    using System.Linq;

    public interface ITownsService
    {
        IQueryable<Town> All();
    }
}