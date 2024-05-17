namespace DataBase.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Group Group { get; set; }
        public uint SongsCount { get; set; }
        public virtual List<Song> Songs { get; set; } = new();
        public Genre Genre { get; set; }
        public int ReleaseYear { get; set; }
        public decimal Price { get; set; }
        public string PublisherName { get; set; }
        public Discount? Discount { get; set; }

        public Album() { }
        public Album(string name, Group group, uint songsCount, Genre genre, int releaseYear, decimal price, string publisherName, Discount? discount = null)
        {
            Name = name;
            Group = group;
            SongsCount = songsCount;
            Genre = genre;
            ReleaseYear = releaseYear;
            Price = price;
            PublisherName = publisherName;
            Discount = discount;
        }

        public override string ToString()
        {
            var result = $"Name: {Name}, Group: {Group.Name}, Songs count: {SongsCount}, Genre: {Genre.Name}, Release year: {ReleaseYear}, Price: {Price}, Publisher name: {PublisherName}";
            return (Discount == null) ? result : result + $", Discount: {Discount.Persent}";
        }
    }
}
