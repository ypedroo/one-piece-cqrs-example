using api.Domain.Models;
using MediatR;

namespace api.Services.Queries;

public class GetAllPiratesQuery : IRequest<List<Pirate>>
{
    
}