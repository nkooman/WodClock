using System;
using System.ComponentModel.DataAnnotations;
using WodClock.Repository.EntityFramework.Abstractions;

namespace WodClock.Repository.EntityFramework.Entities
{
    public class Action : IEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset LastUpdated { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}