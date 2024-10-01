using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using smaple.Models;

namespace smaple.Data
{
    public class smapleContext : DbContext
    {
        public smapleContext (DbContextOptions<smapleContext> options)
            : base(options)
        {
        }

        public DbSet<smaple.Models.Student> Student { get; set; } = default!;
    }
}
