namespace Golddigger.Services
{
    using System.Linq;
    using Golddigger.Models;
    using Golddigger.Services.Contracts;
    using Data.Contracts;

    public class TownsService : ITownsService
    {
        private readonly IRepository<Town> townsRepo;

        public TownsService(IRepository<Town> townsRepo)
        {
            this.townsRepo = townsRepo;
        }

        public IQueryable<Town> All()
        {
            return this.townsRepo.All();
        }
    }
}