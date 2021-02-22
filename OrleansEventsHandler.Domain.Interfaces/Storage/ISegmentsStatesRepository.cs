using System;
using System.Threading;
using System.Threading.Tasks;
using OrleansEventsHandler.Domain.Models.Segments;

namespace OrleansEventsHandler.Domain.Interfaces.Storage
{
    public interface ISegmentsStatesRepository
    {
        Task AddOrUpdateAsync(SegmentsState state, CancellationToken token);

        Task DeleteAsync(Guid accountId, Guid segmentId, long personId, CancellationToken token);

        Task<SegmentsState> GetAsync(Guid accountId, Guid segmentId, long personId, CancellationToken token);
    }
}