using ConsoleApp3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Books> Blog2s { get; set; }
        public DbSet<Authors> Authors { get; set; }

        public BlogContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost;TrustServerCertificate=True;User Id=LAPTOP-5LC5ROF4\Uczen;Integrated Security=true;Initial Catalog=Blog;Connection Timeout=4;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("domyslna_nazwa_schematu");
        }
    }
}
