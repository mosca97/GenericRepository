using GenericRepository.Domain.Core;

namespace GenericRepository.Infrastructures.Repository;
internal sealed class FavouriteRepository : GenericRepository<int, FavouriteDto, FavouriteEntity>, IFavouriteRepository
{
    public FavouriteRepository(ApplicationDbContext context) : base(context)
    {
    }
}

internal class FavouriteEntity
{
    public int Id { get; set; }
}