using System;
using WodClock.Core.Abstractions;

namespace WodClock.Core.Models
{
    public class Action : IModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}