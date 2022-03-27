namespace api.Services.Dtos;

public class GetAllPiratesResponseDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Ship { get; set; }
    public string Rank { get; set; }
    public string Crew { get; set; }
}