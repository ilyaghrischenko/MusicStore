using Microsoft.EntityFrameworkCore;
using DataBase.Models;

namespace DataBase
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer
            ("data source=(localdb)\\MSSQLLocalDB;initial catalog=MusicStore;integrated security=True;MultipleActiveResultSets=true");

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAlbum> UserAlbums { get; set; }
    }
}
