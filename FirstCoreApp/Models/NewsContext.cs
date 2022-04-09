using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstCoreApp.Models
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options)
            : base(options)
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<Catogery> Catogeries { get; set; }
        public DbSet<Contact_Us> Contacts { get; set; }
        public DbSet<Team_Memmber> Team_Memmbers { get; set; }






    }
}
