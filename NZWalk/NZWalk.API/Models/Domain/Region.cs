namespace NZWalk.API.Models.Domain
{
    public class Region
    {
        public Guid RegionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double lat { get; set; }
        public double Long { get; set; }
        public long Polulation { get; set; }

        // collection navigation
        // https://www.entityframeworktutorial.net/efcore/one-to-many-conventions-entity-framework-core.aspx?fbclid=IwAR1-oASBRxJE7YYZmrgvWqjXD8htluip_JGMdeciQB8wEDxpAVRuYNg266M
        public IEnumerable<Walk> Walks;
    }
}
