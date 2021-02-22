using System.Threading.Tasks;
using Orleans;
using OrleansEventsHandler.Domain.Models.Segments;

namespace OrleansEventsHandler.Infrastructure.GrainInterfaces
{
    public interface ISegmentGrain: IGrainWithGuidKey
    {
        Task Create(Segment segment);
        Task Delete();
    }
}