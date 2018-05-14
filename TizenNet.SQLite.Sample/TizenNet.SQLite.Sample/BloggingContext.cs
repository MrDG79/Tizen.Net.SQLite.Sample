using Microsoft.EntityFrameworkCore;

namespace TizenNet.SQLite.Sample
{
    public class BloggingContext : DbContext
    {
        private readonly string _filePath;

        public BloggingContext(string filePath)
        {
            _filePath = filePath;

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_filePath}");
        }

        public DbSet<Blog> Blogs { get; set; }
    }

    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }
}
