using GenericRepository.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Infrastructures.Repository;
internal sealed class FavouriteRepository : GenericRepository<int, FavouriteDto, FavouriteEntity>, IFavouriteRepository
{
}

internal class FavouriteEntity { }