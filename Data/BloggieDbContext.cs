using Microsoft.EntityFrameworkCore;
using Bloggie.Models.Domain;

namespace Bloggie.Data
{
    public class BloggieDbContext: DbContext{

        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}