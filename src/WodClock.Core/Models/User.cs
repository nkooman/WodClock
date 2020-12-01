using System;
using System.Collections.Generic;
using WodClock.Core.Abstractions;

namespace WodClock.Core.Models
{
    public class User : IModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<Guid> ActionTimelineIds { get; set; }
        public IEnumerable<ActionTimeline> ActionTimelines { get; set; }
        public IEnumerable<Guid> ActionIds { get; set; }
        public IEnumerable<Action> Actions { get; set; }
    }
}