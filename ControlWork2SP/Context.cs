using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork2SP
{
    public class Context : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
