using System;

namespace WodClock.Core.Abstractions
{
    public interface IModel
    {
        Guid Id { get; set; }
        DateTimeOffset LastUpdated { get; set; }
        DateTimeOffset CreatedOn { get; set; }
    }
}