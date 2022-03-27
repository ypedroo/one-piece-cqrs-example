namespace api.Domain.Models;

public interface IEntity
{
    long Id { get; set; }
}

public class Pirate : IEntity
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Crew { get; set; }
    public string Rank { get; set; }
    public List<Pirate> Foes { get; set; }
}