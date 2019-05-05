using SportsCoachManagement.Contracts;
using SportsCoachManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private ITestRepository _Test;
        private IUserRepository _User;
        private ITestDetailsRepository _TestDetails;
        private IspTestDetailRepository _sp_TestDetail;
        private IspTotalParticipantsRepository _spTotalParticipants;
        public ITestRepository Test
        {
            get
            {
                if (_Test == null)
                {
                    _Test = new TestRepository(_repoContext);
                }

                return _Test;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_User == null)
                {
                    _User = new UserRepository(_repoContext);
                }

                return _User;
            }
        }

        public ITestDetailsRepository Testdetails
        {
            get
            {
                if (_TestDetails == null)
                {
                    _TestDetails = new TestDetailsRepository(_repoContext);
                }

                return _TestDetails;
            }
        }
        public IspTestDetailRepository sp_TestDetail
        {
            get
            {
                if (_sp_TestDetail == null)
                {
                    _sp_TestDetail = new spTestDetailsRepository(_repoContext);
                }

                return _sp_TestDetail;
            }
        }

        public IspTotalParticipantsRepository spTotalParticipants
        {
            get
            {
                if (_spTotalParticipants == null)
                {
                    _spTotalParticipants = new spTotalParticipantsRepository(_repoContext);
                }
                return _spTotalParticipants;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
