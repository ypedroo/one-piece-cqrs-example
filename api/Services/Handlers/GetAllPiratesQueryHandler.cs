using api.Data.Repositories.Interfaces;
using api.Domain.Models;
using api.Services.Queries;
using MediatR;

namespace api.Services.Handlers;

public class GetAllPiratesQueryHandler : IRequestHandler<GetAllPiratesQuery, List<Pirate>>
{
    private readonly IOnePieceRepository _onePieceRepository;

    public GetAllPiratesQueryHandler(IOnePieceRepository customerRepository) =>
        _onePieceRepository = customerRepository;

    public async Task<List<Pirate>> Handle(GetAllPiratesQuery request, CancellationToken cancellationToken)
    {
        return _onePieceRepository.GetAll().ToList();
    }
}