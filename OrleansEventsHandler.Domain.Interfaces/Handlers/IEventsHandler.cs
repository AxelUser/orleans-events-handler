using System.Threading;
using System.Threading.Tasks;
using OrleansEventsHandler.Domain.Models.Events;

namespace OrleansEventsHandler.Domain.Interfaces.Handlers
{
    public interface IEventsHandler
    {
        Task HandleAsync(Event @event, CancellationToken token);
    }
}