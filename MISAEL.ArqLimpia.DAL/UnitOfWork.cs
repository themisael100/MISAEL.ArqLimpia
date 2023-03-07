using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MISAEL.ArqLimpia.EN.Interfaces;

namespace MISAEL.ArqLimpia.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly MISAELDbContext dbContext;

        public UnitOfWork(MISAELDbContext pDbContext)
        {
            dbContext = pDbContext;
        }
        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();

        }
    }
}
