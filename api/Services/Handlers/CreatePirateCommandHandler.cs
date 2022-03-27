using api.Data.Repositories.Interfaces;
using api.Domain.Models;
using api.Services.Commands;
using MediatR;

namespace api.Services.Handlers;

public class CreatePirateCommandHandler : IRequestHandler<CreatePirateCommand, Pirate>
{
    private readonly IOnePieceRepository _onePieceRepository;

    public CreatePirateCommandHandler(IOnePieceRepository onePieceRepository) =>
        _onePieceRepository = onePieceRepository;

    public async Task<Pirate> Handle(CreatePirateCommand request, CancellationToken cancellationToken)
    {
        return await _onePieceRepository.AddAsync(request.Pirate);
    }
}