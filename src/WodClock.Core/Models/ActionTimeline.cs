using System;
using System.Collections.Generic;
using WodClock.Core.Abstractions;

namespace WodClock.Core.Models
{
    public class ActionTimeline : IModel
    {
        public Guid Id { get;set; }
        public DateTimeOffset LastUpdated { get;set; }
        public DateTimeOffset CreatedOn { get;set; }

        public IEnumerable<ActionStep> ActionSteps { get; set; }
    }
}