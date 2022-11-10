using Microsoft.AspNetCore.Mvc;
using NZWalk.API.Models.Domain;
using NZWalk.API.Models.DTO;
using NZWalk.API.Repository;

namespace NZWalk.API.Controllers
{
    [Route("api/Regions")]
    [ApiController] 
    public class RegionsController : Controller
    {
        private readonly IRegionRepository _regionRepository;

        public RegionsController(IRegionRepository regionRepository)
        {
            this._regionRepository = regionRepository;
        }

        [HttpGet]
        public async Task<List<RegionDTO>> GetAll()
        {
            var _regions = await _regionRepository.GetAllRegion();
            var _regionsDtos = new List<RegionDTO>();
            _regions.ToList().ForEach (region =>
            {
                var regionsDto = new RegionDTO()
                {
                    Area = region.Area,
                    Code = region.Code,
                    RegionId = region.RegionId,
                    RegionName = region.Name,
                    lat = region.lat,
                    Long = region.Long, 
                    Polulation = region.Polulation 
                };
                _regionsDtos.Add(regionsDto);
            });

            return _regionsDtos;
        }
    }
}
