using SportsCoachManagement.Contracts;
using SportsCoachManagement.Entities;
using SportsCoachManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Repository
{
    public class TestDetailsRepository : RepositoryBase<TestDetails>, ITestDetailsRepository
    {
        public TestDetailsRepository(RepositoryContext repositoryContext)
                 : base(repositoryContext)
        {
        }
        public IEnumerable<TestDetails> GetAllTestDetails()
        {
            return FindAll()
                .OrderBy(ow => ow.Id)
                .ToList();
        }
    }
}
