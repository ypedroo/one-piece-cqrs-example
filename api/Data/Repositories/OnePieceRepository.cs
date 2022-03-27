using api.Data.Repositories.Interfaces;
using api.Domain.Context;
using api.Domain.Models;

namespace api.Data.Repositories;

public class OnePieceRepository : GenericRepository<Pirate>, IOnePieceRepository
{
    public OnePieceRepository(OnePieceDbContext context) : base(context)
    {
    }
}
