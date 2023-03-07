using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MISAEL.ArqLimpia.EN;
using Microsoft.EntityFrameworkCore;

namespace MISAEL.ArqLimpia.DAL
{
    public class MISAELDbContext : DbContext
    {
        public MISAELDbContext(DbContextOptions<MISAELDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
    }
}
