using System;

namespace OrleansEventsHandler.Domain.Models.Segments
{
    public class BehaviorSegment
    {
        public Guid SegmentId { get; set; }
        
        public Guid AccountId { get; set; }

        public Guid PersonId { get; set; }

        public PayloadCondition[] PayloadConditions { get; set; }

        public TimelineCondition TimelineCondition { get; set; }

        public OccurrenceCondition OccurrenceCondition { get; set; }
    }
}