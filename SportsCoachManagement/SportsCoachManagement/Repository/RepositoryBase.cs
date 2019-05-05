using Microsoft.EntityFrameworkCore;
using SportsCoachManagement.Contracts;
using SportsCoachManagement.Entities;
using SportsCoachManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SportsCoachManagement.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>()
                .AsNoTracking();
        }
        
        public IEnumerable<spTotalParticipants> Getallparticipants()
        {          
            List<spTotalParticipants> spTotalParticipants = this.RepositoryContext.spTotalParticipants
                      .FromSql($"spTotalParticipants")
                      .ToList();
            return spTotalParticipants;
        }

        public IEnumerable<sp_TestDetail> GetAllTestDetails()
        {
            List<sp_TestDetail> spTestDetail = this.RepositoryContext.sp_TestDetail
                      .FromSql($"sp_TestDetail")
                      .ToList();
            return spTestDetail;
        }


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>()
                .Where(expression)
                .AsNoTracking();
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }
    }
}
