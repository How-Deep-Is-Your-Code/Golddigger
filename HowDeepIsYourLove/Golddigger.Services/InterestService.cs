namespace Golddigger.Services
{
    using System.Linq;
    using Golddigger.Models;
    using Golddigger.Services.Contracts;
    using Data.Contracts;

    public class InterestService : IInterestService
    {
        private readonly IRepository<Interest> interestRepo;

        public InterestService(IRepository<Interest> interestRepo)
        {
            this.interestRepo = interestRepo;
        }

        public IQueryable<Interest> All()
        {
            return interestRepo.All();
        }
    }
}
