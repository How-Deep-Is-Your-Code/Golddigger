namespace Golddigger.Data.Contracts
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Golddigger.Models;

    public interface IGolddiggerDbContext
    {
        //IDbSet<Comment> Comments { get; set; }

        //IDbSet<RealEstate> RealEstates { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
