using System.Threading.Tasks;
using Orleans;
using OrleansEventsHandler.Domain.Models.Events;
using OrleansEventsHandler.Orleans.GrainInterfaces;

namespace OrleansEventsHandler.Infrastructure.Grains
{
    public class PersonGrain: Grain, IPersonGrain
    {
        public PersonGrain()
        {
            
        }
        
        public Task HandleEvent(Event @event)
        {
            throw new System.NotImplementedException();
        }
    }
}