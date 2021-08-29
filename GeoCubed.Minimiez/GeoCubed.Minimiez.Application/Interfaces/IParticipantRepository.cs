using GeoCubed.Minimiez.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Interfaces
{
    public interface IParticipantRepository : IAsyncRepository
    {
        Task<IReadOnlyList<Participants>> GetAllParticipants();
    }
}
