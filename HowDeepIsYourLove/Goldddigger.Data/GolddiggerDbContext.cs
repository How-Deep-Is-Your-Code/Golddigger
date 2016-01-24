namespace Golddigger.Data
{
    using Contracts;
    using Golddigger.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class GolddiggerDbContext : IdentityDbContext<User>, IGolddiggerDbContext
    {
        public virtual IDbSet<Comment> Comments { get; set; }

        public virtual IDbSet<Country> Countries { get; set; }

        public virtual IDbSet<Interest> Interests { get; set; }

        public virtual IDbSet<Photo> Photo { get; set; }

        public virtual IDbSet<Town> Town { get; set; }

        public virtual IDbSet<UserInfo> UserInfo { get; set; }

        public GolddiggerDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static GolddiggerDbContext Create()
        {
            return new GolddiggerDbContext();
        }
    }
}
