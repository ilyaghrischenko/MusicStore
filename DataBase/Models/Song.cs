namespace DataBase.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }
        public Album Album { get; set; }

        public Song() { }
        public Song(string name, double duration, Album album)
        {
            Name = name;
            Duration = duration;
            Album = album;
        }

        public override string ToString()
        => $"Name: {Name}, Duration: {Duration}, Album: {Album.Name}";
    }
}
