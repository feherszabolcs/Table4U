using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Table4U;

namespace Table4U.Data
{
    public class Table4UContext : DbContext
    {
        public Table4UContext (DbContextOptions<Table4UContext> options)
            : base(options)
        {
        }

        public DbSet<Table4U.Reservation> Reservation { get; set; } = default!;
        public DbSet<Table4U.Table> Table { get; set; } = default!;
    }
}
