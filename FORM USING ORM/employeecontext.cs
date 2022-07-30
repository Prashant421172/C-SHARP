using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FROM_ORM
{
    internal class employeecontext : DbContext
    {
        public DbSet<employee> Employee1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NSL-LTRG008\\SQLEXPRESS2019;Database=satish; Integrated Security=True;");
            }
        }
    }
}