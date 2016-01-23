namespace Golddigger.App_Start
{
    using System.Data.Entity;
    using Golddigger.Data;
    using Golddigger.Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GolddiggerDbContext,Configuration>());
            GolddiggerDbContext.Create().Database.Initialize(true);
        }
    }
}