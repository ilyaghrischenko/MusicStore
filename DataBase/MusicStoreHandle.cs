using DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public static class MusicStoreHandle
    {
        public static async Task<List<Album>> GetAlbumsAsync()
        {
            using MusicStoreContext db = new();
            return await db.Albums
                             .Include("Group")
                             .Include("Genre")
                             .Include("Discount")
                             .ToListAsync();
        }
        public static async Task<List<Discount>> GetDiscountsAsync()
        {
            using MusicStoreContext db = new();
            return await db.Discounts
                             .Include("Genre")
                             .ToListAsync();
        }
        public static async Task<List<Genre>> GetGenresAsync()
        {
            using MusicStoreContext db = new();
            return await db.Genres.ToListAsync();
        }
        public static async Task<List<Group>> GetGroupsAsync()
        {
            using MusicStoreContext db = new();
            return await db.Groups.ToListAsync();
        }
        public static async Task<List<Song>> GetSongsAsync()
        {
            using MusicStoreContext db = new();
            return await db.Songs
                             .Include("Album")
                             .Include("Album.Group")
                             .Include("Album.Genre")
                             .Include("Album.Discount")
                             .ToListAsync();
        }
        public static async Task<List<User>> GetUsersAsync()
        {
            using MusicStoreContext db = new();
            return await db.Users.ToListAsync();
        }
        public static async Task<List<UserAlbum>> GetUserAlbumsAsync()
        {
            using MusicStoreContext db = new();
            return await db.UserAlbums
                             .Include("User")
                             .Include("Album")
                             .Include("Album.Group")
                             .Include("Album.Genre")
                             .Include("Album.Discount")
                             .ToListAsync();
        }
    }
}
