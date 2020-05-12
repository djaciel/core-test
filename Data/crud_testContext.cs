using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crud_test.Models;

namespace crud_test.Data
{
    public class crud_testContext : DbContext
    {
        public crud_testContext (DbContextOptions<crud_testContext> options)
            : base(options)
        {
        }

        public DbSet<crud_test.Models.Employee> Employee { get; set; }
    }
}
