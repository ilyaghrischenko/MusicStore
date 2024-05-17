namespace DataBase.Models
{
    public class UserAlbum
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Album Album { get; set; }

        public UserAlbum() { }
        public UserAlbum(User user, Album album)
        {
            User = user;
            Album = album;
        }

        public override string ToString()
        => $"User: {User.Login}, Album: {Album.Name}";
    }
}
