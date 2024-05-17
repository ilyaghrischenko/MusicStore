namespace DataBase.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Genre() { }
        public Genre(string name)
        {            
            Name = name;
        }

        public override string ToString()
        => $"Name: {Name}";
    }
}
