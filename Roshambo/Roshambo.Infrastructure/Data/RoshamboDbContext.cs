using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Identity.Client;
using Roshambo.Core.Entities;

namespace Roshambo.Infrastructure.Data
{
    public class RoshamboDbContext : DbContext
    {
        public RoshamboDbContext() : base() { }
        public RoshamboDbContext(DbContextOptions<RoshamboDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
