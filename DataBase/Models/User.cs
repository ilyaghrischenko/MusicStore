namespace DataBase.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual List<Album>? Albums { get; set; } = new();

        public User() { }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public override string ToString()
        => $"First name: {Login}, Last name: {Password}";
    }
}
