using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodnwsWebApp.Models
{
    public class GoodnwsDbContext : DbContext
    {
        public GoodnwsDbContext(DbContextOptions<GoodnwsDbContext> options) : base(options)
        {
        }

        public DbSet<Story> Stories { get; set; }
    }
}
