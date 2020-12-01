using Microsoft.EntityFrameworkCore;

namespace WodClock.Repository.EntityFramework.Extensions
{
    public static class SeedingExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
            => modelBuilder.SeedUsers();
    }
}