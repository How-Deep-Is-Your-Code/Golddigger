namespace Golddigger.Data
{
    using Golddigger.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class GolddiggerDbContext : IdentityDbContext<User>
    {
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
