using System.Reflection.Metadata;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using WodClock.Repository.EntityFramework.Entities;
using System;

namespace WodClock.Repository.EntityFramework.Extensions
{
    public static class SeedUserExtensions
    {
        public static ModelBuilder SeedUsers(this ModelBuilder builder)
            => builder
                .Entity<User>(e => e.HasData(
                    new User()
                    {
                        Id = new Guid("f4be4361-a4dd-426c-b2c6-9dd249f47557"),
                        FirstName = "John",
                        LastName = "Doe",
                        CreatedOn = new DateTimeOffset(),
                        LastUpdated = new DateTimeOffset()
                    }))
                .Entity<User>(e => e.HasData(
                    new User()
                    {
                        Id = new Guid("9becad37-9ffe-43c9-859b-0ff3a4e31923"),
                        FirstName = "Jane",
                        LastName = "Doe",
                        CreatedOn = new DateTimeOffset(),
                        LastUpdated = new DateTimeOffset()
                    }));
    }
}