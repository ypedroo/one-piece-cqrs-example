namespace api.Services.Dtos;

public class CreatePirateRequestDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Crew { get; set; }
    public string Rank { get; set; }
    public string Ship { get; set; }
}