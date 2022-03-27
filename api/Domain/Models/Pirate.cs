using api.Domain.Interfaces;

namespace api.Domain.Models;

public class Pirate : IEntity
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Ship { get; set; }

    public string Crew { get; set; }
    public string Rank { get; set; }
}