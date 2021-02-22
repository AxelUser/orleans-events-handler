using System;
using System.Collections.Generic;

namespace OrleansEventsHandler.Domain.Models.Segments
{
    public class SegmentsState
    {
        public Guid AccountId { get; set; }
        public long PersonId { get; set; }
        public Guid SegmentId { get; set; }

        public List<DateTime> Dates { get; set; }
        public int Count { get; set; }
    }
}