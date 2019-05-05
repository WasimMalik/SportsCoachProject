using SportsCoachManagement.Contracts;
using SportsCoachManagement.Entities;
using SportsCoachManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Repository
{
    public class spTestDetailsRepository : RepositoryBase<sp_TestDetail>, IspTestDetailRepository
    {
        public spTestDetailsRepository(RepositoryContext repositoryContext)
                 : base(repositoryContext)
        {
        }
        public IEnumerable<sp_TestDetail> GetAllTestDetails(string TestName, DateTime testdate)
        {
            return GetAllTestDetails()//.Where(a=>a.TestName== TestName && a.Testdate== testdate)
                .OrderBy(ow => ow.SerialNumber)
                .ToList();
        }
    }
}
