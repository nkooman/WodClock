using Microsoft.EntityFrameworkCore;
using WodClock.Repository.EntityFramework.Entities;
using WodClock.Repository.EntityFramework.Extensions;

namespace WodClock.Repository.EntityFramework
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedData();

            base.OnModelCreating(builder);
        }
    }
}