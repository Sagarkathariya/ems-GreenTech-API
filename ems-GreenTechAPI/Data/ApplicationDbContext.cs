using ems_GreenTechAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ems_GreenTechAPI.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions options) : base(options) {
        }
        /* public ApplicationDbContext(DbContextOptions options) : base(options)
         {
         }*/

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Category> Categories{ get; set; }
    }
}
