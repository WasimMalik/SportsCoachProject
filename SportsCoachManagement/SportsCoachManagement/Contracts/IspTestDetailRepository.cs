using SportsCoachManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Contracts
{
   public interface IspTestDetailRepository: IRepositoryBase<sp_TestDetail>
    {
        IEnumerable<sp_TestDetail> GetAllTestDetails(string TestName, DateTime testdate);
    }
}
