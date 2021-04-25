using System.Threading.Tasks;
using Orleans;
using OrleansEventsHandler.Domain.Models.Events;

namespace OrleansEventsHandler.Orleans.GrainInterfaces
{
    public interface IPersonGrain: IGrainWithGuidCompoundKey
    {
        Task HandleEvent(Event @event);
    }
}