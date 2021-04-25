using System;
using System.Threading.Tasks;
using Orleans;
using OrleansEventsHandler.Domain.Models.Segments;

namespace OrleansEventsHandler.Orleans.GrainInterfaces
{
    public interface IAccountSegmentsGrain: IGrainWithGuidKey
    {
        Task AddSegment(BehaviorSegment behaviorSegment);

        Task DeleteSegment(Guid segmentId);
    }
}