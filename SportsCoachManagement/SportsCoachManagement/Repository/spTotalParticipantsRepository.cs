using SportsCoachManagement.Contracts;
using SportsCoachManagement.Entities;
using SportsCoachManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Repository
{
    public class spTotalParticipantsRepository : RepositoryBase<spTotalParticipants>, IspTotalParticipantsRepository
    {
        public spTotalParticipantsRepository(RepositoryContext repositoryContext)
                : base(repositoryContext)
        {
        }
        public IEnumerable<spTotalParticipants> GetTotalParticipants()
        {
            return Getallparticipants();
        }
    }
}
