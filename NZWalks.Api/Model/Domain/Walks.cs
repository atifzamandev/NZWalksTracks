namespace NZWalks.Api.Model.Domain
{
    public class Walks
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }

        public Guid DifficultyId { get; set; }

        public Guid ReginId { get; set; }

        public required Difficulity Difficulty { get; set; }
        public required Region Region { get; set; }

    }
}
