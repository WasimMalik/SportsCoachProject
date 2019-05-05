using SportsCoachManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Contracts
{
    public interface IspTotalParticipantsRepository : IRepositoryBase<spTotalParticipants>
    {
        IEnumerable<spTotalParticipants> GetTotalParticipants();
    }
}
