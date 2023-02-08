namespace NET_Mom3.Models {
    
    public class CD {

        // Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly PublishedDate { get; set; }
        public int Tracks { get; set; } // Antalet låtar på skivan
        public string? Length { get; set; } // Total låtlängd på skiva

    }

}