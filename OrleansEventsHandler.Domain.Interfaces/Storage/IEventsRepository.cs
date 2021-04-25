using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OrleansEventsHandler.Domain.Models.Events;
using OrleansEventsHandler.Domain.Models.Identifiers;
using OrleansEventsHandler.Domain.Models.Segments;

namespace OrleansEventsHandler.Domain.Interfaces.Storage
{
    public interface IEventsRepository
    {
        Task AddAsync(Event @event, CancellationToken token);

        IAsyncEnumerable<DateTime> FindDatesAsync(BehaviorSegment segment, CancellationToken token);

        IAsyncEnumerable<PersonId> FindPersonsAsync(BehaviorSegment segment, CancellationToken token);
    }
}