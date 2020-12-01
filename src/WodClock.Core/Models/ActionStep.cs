using System;
using WodClock.Core.Abstractions;

namespace WodClock.Core.Models
{
    public class ActionStep
    {
        public Action Action { get; set; }
        public int Duration { get; set; }
        public int Order { get; set; }
    }
}