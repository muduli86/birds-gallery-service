namespace birds_gallery_service.Persistence.Entities
{
    public class Birds 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string[] Images { get; set; }
    }
}