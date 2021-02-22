using System;
using System.Collections.Generic;

namespace OrleansEventsHandler.Domain.Models.Events
{
    public class Event
    {
        public Guid AccountId { get; set; }

        public long PersonId { get; set; }

        public string DefinitionId { get; set; }

        public IDictionary<string, string> Payload { get; set; }

        public DateTime OccurrenceTime { get; set; }
    }
}