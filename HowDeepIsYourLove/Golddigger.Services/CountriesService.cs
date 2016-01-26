using System;
using System.Linq;
using Golddigger.Models;
using Golddigger.Services.Contracts;
using Golddigger.Data.Contracts;

namespace Golddigger.Services
{
    public class CountriesService : ICountriesService
    {
        private readonly IRepository<Country> countriesRepo;

        public CountriesService(IRepository<Country> countriesRepo)
        {
            this.countriesRepo = countriesRepo;
        }

        public IQueryable<Country> All()
        {
            return this.countriesRepo.All();
        }
    }
}