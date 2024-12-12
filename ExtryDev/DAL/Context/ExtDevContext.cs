using ExtryDev.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ExtryDev.DAL.Context
{
    public class ExtDevContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=ExtDevDb;User=root;Password =fener1907O.l;",
                new MySqlServerVersion(new Version (8,0,23)));
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
