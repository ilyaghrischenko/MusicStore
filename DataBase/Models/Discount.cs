namespace DataBase.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public Genre Genre { get; set; }
        public int Persent { get; set; }

        public Discount() { }
        public Discount(Genre genre, int persent)
        {
            Genre = genre;
            Persent = persent;
        }

        public override string ToString()
        => $"Genre: {Genre.Name}, Persent: {Persent}";
    }
}
