using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;

namespace Repository
{
    public class SparePartRepository : RepositoryBase<SparePart>, ISparePartRepository
    {
        public SparePartRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        { 
        }
    }
}
