using System.Threading.Tasks;
using Orleans;
using OrleansEventsHandler.Domain.Models.Segments;
using OrleansEventsHandler.Infrastructure.GrainInterfaces;

namespace OrleansEventsHandler.Infrastructure.Grains
{
    public class SegmentGrain: Grain, ISegmentGrain
    {
        public Task Create(Segment segment)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}