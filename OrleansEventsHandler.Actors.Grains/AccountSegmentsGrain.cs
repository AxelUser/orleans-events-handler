using System;
using System.Threading.Tasks;
using Orleans;
using OrleansEventsHandler.Domain.Models.Segments;
using OrleansEventsHandler.Orleans.GrainInterfaces;

namespace OrleansEventsHandler.Infrastructure.Grains
{
    public class AccountSegmentsGrain: Grain, IAccountSegmentsGrain
    {
        public Task AddSegment(BehaviorSegment behaviorSegment)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteSegment(Guid segmentId)
        {
            throw new System.NotImplementedException();
        }
    }
}