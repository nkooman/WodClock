using System;
using System.ComponentModel.DataAnnotations;

namespace WodClock.Repository.EntityFramework.Abstractions
{
    public interface IEntity
    {
        [Key]
        Guid Id { get; set; }
        DateTimeOffset CreatedOn { get; set; }
        DateTimeOffset LastUpdated { get; set; }
    }
}