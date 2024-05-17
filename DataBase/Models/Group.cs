namespace DataBase.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public uint ParticipantNumber { get; set; }
        public virtual List<Album> Albums { get; set; } = new();

        public Group() { }
        public Group(string name, uint participantNumber)
        {
            Name = name;
            ParticipantNumber = participantNumber;
        }

        public override string ToString()
        => $"Name: {Name}, Participant number: {ParticipantNumber}";
    }
}
