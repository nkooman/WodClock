using System;
using System.Collections.Generic;
using WodClock.Repository.EntityFramework.Abstractions;

namespace WodClock.Repository.EntityFramework.Entities
{
    public class ActionTimeline : IEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset LastUpdated { get; set; }

        public IEnumerable<ActionStep> ActionSteps { get; set; }
    }
}