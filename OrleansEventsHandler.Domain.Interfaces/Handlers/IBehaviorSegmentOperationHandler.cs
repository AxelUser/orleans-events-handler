using System;
using System.Threading.Tasks;
using OrleansEventsHandler.Domain.Models.Segments;

namespace OrleansEventsHandler.Domain.Interfaces.Handlers
{
    public interface IBehaviorSegmentOperationHandler
    {
        Task CreateAsync(BehaviorSegment behaviorSegment);
        Task DeleteAsync(Guid segmentId);
    }
}