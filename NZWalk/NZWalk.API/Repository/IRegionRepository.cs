using NZWalk.API.Models.Domain;

namespace NZWalk.API.Repository
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllRegion();
    }
}
