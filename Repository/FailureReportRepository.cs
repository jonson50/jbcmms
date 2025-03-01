using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;

namespace Repository
{
    public class FailureReportRepository : RepositoryBase<FailureReport>, IFailureReportRepository
    {
        public FailureReportRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
