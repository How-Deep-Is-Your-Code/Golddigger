namespace Golddigger.Data.Contracts
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Golddigger.Models;

    public interface IGolddiggerDbContext
    {
        IDbSet<Comment> Comments { get; set; }

        IDbSet<Country> Countries { get; set; }

        IDbSet<Interest> Interests { get; set; }

        IDbSet<Photo> Photo { get; set; }

        IDbSet<Town> Town { get; set; }

        IDbSet<UserInfo> UserInfo { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
