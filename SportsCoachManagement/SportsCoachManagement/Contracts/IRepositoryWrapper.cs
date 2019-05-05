using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Contracts
{
   public interface IRepositoryWrapper
    {
        ITestDetailsRepository Testdetails { get; }
        ITestRepository Test { get; }
        IUserRepository User { get; }
        IspTestDetailRepository sp_TestDetail { get; }
        IspTotalParticipantsRepository spTotalParticipants { get; }
        void Save();
    }
}

