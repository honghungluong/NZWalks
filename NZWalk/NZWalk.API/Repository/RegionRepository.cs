using Microsoft.EntityFrameworkCore;
using NZWalk.API.Data;
using NZWalk.API.Models.Domain;

namespace NZWalk.API.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly DataContext _dataContext;

        public RegionRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        async Task<List<Region>> IRegionRepository.GetAllRegion() => await _dataContext.Regions.ToListAsync();
    }
}
