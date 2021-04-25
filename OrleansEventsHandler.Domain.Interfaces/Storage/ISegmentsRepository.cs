using System;
using System.Threading;
using System.Threading.Tasks;
using OrleansEventsHandler.Domain.Models.Segments;

namespace OrleansEventsHandler.Domain.Interfaces.Storage
{
    public interface ISegmentsRepository
    {
        Task AddAsync(BehaviorSegment behaviorSegments, CancellationToken token);

        Task DeleteAsync(Guid segmentId, CancellationToken token);

        Task<BehaviorSegment> GetAsync(Guid segmentId, CancellationToken token);
    }
}