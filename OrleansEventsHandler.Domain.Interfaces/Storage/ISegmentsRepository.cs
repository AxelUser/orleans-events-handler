using System;
using System.Threading;
using System.Threading.Tasks;
using OrleansEventsHandler.Domain.Models.Segments;

namespace OrleansEventsHandler.Domain.Interfaces.Storage
{
    public interface ISegmentsRepository
    {
        Task AddAsync(Segment segments, CancellationToken token);

        Task DeleteAsync(Guid segmentId, CancellationToken token);

        Task<Segment> GetAsync(Guid segmentId, CancellationToken token);
    }
}