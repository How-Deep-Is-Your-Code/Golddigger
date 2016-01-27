namespace Golddigger.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<GolddiggerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Golddigger.Data.GolddiggerDbContext";
        }

        protected override void Seed(GolddiggerDbContext context)
        {
            context.Interests.AddOrUpdate(
                i => i.InterestId,
                new Interest() { Name = "Scuba Diving", InterestId = 1 },
                new Interest() { Name = "Cars", InterestId = 2 },
                new Interest() { Name = "Shoping", InterestId = 3 },
                new Interest() { Name = "Traveling", InterestId = 4 },
                new Interest() { Name = "Fitness", InterestId = 5 },
                new Interest() { Name = "Movies", InterestId = 6 },
                new Interest() { Name = "Writting", InterestId = 7 },
                new Interest() { Name = "Yoga", InterestId = 8 },
                new Interest() { Name = "Parties", InterestId = 9 },
                new Interest() { Name = "Clubbin'", InterestId = 10 },
                new Interest() { Name = "Teddy bears", InterestId = 11 },
                new Interest() { Name = "EVERYTHING PINK", InterestId = 12 }
                );

            context.Countries.AddOrUpdate(
                c => c.Id,
                new Country() { Name = "Bulgaria", Id = 1 },
                new Country() { Name = "USA", Id = 2 },
                new Country() { Name = "Germany", Id = 3 },
                new Country() { Name = "UK", Id = 4 },
                new Country() { Name = "Russia", Id = 5 },
                new Country() { Name = "France", Id = 6 },
                new Country() { Name = "Spain", Id = 7 },
                new Country() { Name = "Canada", Id = 8 },
                new Country() { Name = "Greece", Id = 9 },
                new Country() { Name = "China", Id = 10 }
                );

            context.Town.AddOrUpdate(
                t => t.Id,
                new Town() { Name = "Sofia", Id = 1},
                new Town() { Name = "pLOVEdiv", Id = 2 },
                new Town() { Name = "Burgas", Id = 3 },
                new Town() { Name = "Varna", Id = 4 },
                new Town() { Name = "New York", Id = 5 },
                new Town() { Name = "LA", Id = 6 },
                new Town() { Name = "Palo Alto", Id = 7 },
                new Town() { Name = "San Francisco", Id = 8 },
                new Town() { Name = "Frankfurt", Id = 9 },
                new Town() { Name = "Berlin", Id = 10 },
                new Town() { Name = "Munich", Id = 11 },
                new Town() { Name = "Stuttgard", Id = 12 },
                new Town() { Name = "London", Id = 13 },
                new Town() { Name = "Edinburgh", Id = 14 },
                new Town() { Name = "York", Id = 15 },
                new Town() { Name = "Bath", Id = 16 },
                new Town() { Name = "Moscow", Id = 17 },
                new Town() { Name = "Saint Petersburg", Id = 18 },
                new Town() { Name = "Novosibirsk", Id = 19 },
                new Town() { Name = "Yekaterinburg", Id = 20 },
                new Town() { Name = "Paris", Id = 21 },
                new Town() { Name = "Versailles", Id = 22 },
                new Town() { Name = "Nice", Id = 23 },
                new Town() { Name = "Lourdes", Id = 24 },
                new Town() { Name = "Barcelona", Id = 25 },
                new Town() { Name = "Granada", Id = 26 },
                new Town() { Name = "Madrid", Id = 27 },
                new Town() { Name = "Seville", Id = 28 },
                new Town() { Name = "Ottawa", Id = 29 },
                new Town() { Name = "Quebec", Id = 30 },
                new Town() { Name = "Boucherville", Id = 31 },
                new Town() { Name = "Burlington", Id = 32 },
                new Town() { Name = "Athens", Id = 33 },
                new Town() { Name = "Crete", Id = 34 },
                new Town() { Name = "Meteora", Id = 35 },
                new Town() { Name = "Delphi", Id = 36 },
                new Town() { Name = "Shanghai", Id = 37 },
                new Town() { Name = "Beijing", Id = 38 },
                new Town() { Name = "Tianjin", Id = 39 },
                new Town() { Name = "Guangzhou", Id = 40 }
                );
        }
    }
}
