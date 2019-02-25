using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCNovicell.Models
{
    public class MVCNovicellContext : DbContext
    {
        public MVCNovicellContext (DbContextOptions<MVCNovicellContext> options)
            : base(options)
        {
        }

        public DbSet<MVCNovicell.Models.Game> Game { get; set; }
    }
}
