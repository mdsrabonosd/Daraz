using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using daraz.Datamodel;

namespace daraz.Data
{
    public class darazContext : DbContext
    {
        public darazContext (DbContextOptions<darazContext> options)
            : base(options)
        {
        }

        public DbSet<daraz.Datamodel.Customer> Customer { get; set; } = default!;

        public DbSet<daraz.Datamodel.Invoice> Invoice { get; set; } = default!;

        public DbSet<daraz.Datamodel.Johan> Johan { get; set; } = default!;

        public DbSet<daraz.Datamodel.Block> Block { get; set; } = default!;
    }
}
