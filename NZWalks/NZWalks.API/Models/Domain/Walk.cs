namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public double Length { get; set; }

        // Navigation Properties
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }
    }
}
