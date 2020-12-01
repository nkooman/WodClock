using System;
using System.Collections.Generic;
using WodClock.Repository.EntityFramework.Abstractions;

namespace WodClock.Repository.EntityFramework.Entities
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset LastUpdated { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<Guid> ActionTimelineIds { get; set; }
    }
}