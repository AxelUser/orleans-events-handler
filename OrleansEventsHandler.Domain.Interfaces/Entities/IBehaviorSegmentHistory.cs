using System.Threading;
using System.Threading.Tasks;
using OrleansEventsHandler.Domain.Models.Events;

namespace OrleansEventsHandler.Domain.Interfaces.Entities
{
    public interface IBehaviorSegmentHistory
    {
        public Task ApplyAsync(Event @event, CancellationToken token);
    }
}