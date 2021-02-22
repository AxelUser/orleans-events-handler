using System.Threading.Tasks;
using Orleans;
using OrleansEventsHandler.Domain.Models.Events;
using OrleansEventsHandler.Infrastructure.GrainInterfaces;

namespace OrleansEventsHandler.Infrastructure.Grains
{
    public class PersonGrain: Grain, IPersonGrain
    {
        public Task HandleEvent(Event @event)
        {
            throw new System.NotImplementedException();
        }
    }
}