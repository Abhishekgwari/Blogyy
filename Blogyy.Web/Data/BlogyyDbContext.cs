using Blogyy.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blogyy.Web.Data
{
    public class BlogyyDbContext : DbContext
    {
        public BlogyyDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
