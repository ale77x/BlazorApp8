using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApp8.Data;

namespace BlazorApp8.Data
{
    public class BlazorApp8Context(DbContextOptions<BlazorApp8Context> options) : IdentityDbContext<BlazorApp8User>(options)
    {
        public DbSet<BlazorApp8.Models.Vehicle> Vehicle { get; set; } = default!;
    }
}
