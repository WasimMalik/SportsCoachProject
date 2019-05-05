using SportsCoachManagement.Contracts;
using SportsCoachManagement.Entities;
using SportsCoachManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {
        }

        public void Create(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> FindByCondition(System.Linq.Expressions.Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<User> IRepositoryBase<User>.FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
