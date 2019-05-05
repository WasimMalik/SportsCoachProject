using SportsCoachManagement.Contracts;
using SportsCoachManagement.Entities;
using SportsCoachManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SportsCoachManagement.Repository
{
    public class TestRepository : RepositoryBase<Test>, ITestRepository
    {
        public TestRepository(RepositoryContext repositoryContext)
          : base(repositoryContext)
        {
        }
        public IEnumerable<Test> GetAllTest()
        {
            return FindAll()
                .OrderBy(ow => ow.Id)
                .ToList();
        }
    }
}
