using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Site.Data.Entities;

namespace Site.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ContactUsEntry> ContactUsEntries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { 
        }
    }
}
