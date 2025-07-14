using CodeFirstWithTableRelation.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstWithTableRelation.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<BookEntity>Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
        @"Server=.\SQLEXPRESS;Database=CodeFirstWithTableRelation;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False"
    );

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookEntity>().HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);
        }
    }
}
