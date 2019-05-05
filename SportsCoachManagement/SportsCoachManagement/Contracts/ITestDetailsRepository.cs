using SportsCoachManagement.Entities.Models;
using SportsCoachManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Contracts
{
    public interface ITestDetailsRepository : IRepositoryBase<TestDetails>
    {
        IEnumerable<TestDetails> GetAllTestDetails();
    }
}
