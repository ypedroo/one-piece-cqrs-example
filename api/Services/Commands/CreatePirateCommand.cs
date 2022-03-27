using api.Domain.Models;
using MediatR;

namespace api.Services.Commands;

public class CreatePirateCommand : IRequest<Pirate>
{
    public Pirate Pirate { get; set; }
}