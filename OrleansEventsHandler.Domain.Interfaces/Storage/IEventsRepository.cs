using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OrleansEventsHandler.Domain.Models.Events;

namespace OrleansEventsHandler.Domain.Interfaces.Storage
{
    public interface IEventsRepository
    {
        Task AddAsync(Event @event, CancellationToken token);

        IAsyncEnumerable<Event> ListAsync(CancellationToken token);
    }
}