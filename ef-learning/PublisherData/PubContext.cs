using Microsoft.EntityFrameworkCore;
using PublisherDomian;

namespace PublisherData
{
    public class PubContext:DbContext
    {
        public DbSet <Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-Q8FU87I\\SQLEXPRESS; database = Publisher; TrustServerCertificate = true; Trusted_Connection = true; user Id  = sa; password = wamuyu@2023 ") ;//connecting to my database

        }
    }
}