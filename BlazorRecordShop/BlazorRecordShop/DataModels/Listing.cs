namespace BlazorRecordShop.DataModels
{
    public record Listing
    {
        public int Id { get; set; }
        public string AlbumId { get; set; }
        public double Price { get; set; }
        public MediaCondition Condition { get; set; } = MediaCondition.Unkown;
        public string Description { get; set; } = string.Empty;
        public string CatalogNumber {  get; set; } = string.Empty;
        public int Year { get; set; } = 0;
        public MediaFormat Format { get; set; } = MediaFormat.Vinyl;
        public string Label { get; set; } = String.Empty;
    }
}
