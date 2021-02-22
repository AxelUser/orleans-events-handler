using System;
using System.Collections.Generic;

namespace GrainInterfaces.Events
{
    public class Event
    {
        public Guid AccountId { get; set; }

        public Guid PersonId { get; set; }

        public Guid DefinitionId { get; set; }

        public IDictionary<string, string> Payload { get; set; }

        public DateTime OccurrenceTime { get; set; }
    }
}