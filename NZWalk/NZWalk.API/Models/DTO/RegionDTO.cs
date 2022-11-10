namespace NZWalk.API.Models.DTO
{
    public class RegionDTO
    {
        public Guid RegionId { get; set; }
        public string Code { get; set; }
        public string RegionName { get; set; }
        public double Area { get; set; }
        public double lat { get; set; }
        public double Long { get; set; }
        public long Polulation { get; set; }
    }
}
