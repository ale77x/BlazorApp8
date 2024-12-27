using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp8.Models;

namespace BlazorApp8.Data
{
    public class BlazorApp8Context : DbContext
    {
        public BlazorApp8Context (DbContextOptions<BlazorApp8Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp8.Models.Vehicle> Vehicle { get; set; } = default!;
    }
}
