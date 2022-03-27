namespace api.Services.Dtos;

public class GetAllPiratesRequestDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Nickname { get; set; }
    public string Ship { get; set; }
    public string Rank { get; set; }
    public string Captain { get; set; }
    public string Crew { get; set; }
}