namespace NET_Mom3.Models {

    public class Artist {

    // Properties
    public int ArtistId { get; set; }
    public string? Name { get; set; }

    public List<CD>? CDs { get; set; } // Lista på CDs

    }

    
    public class CD {

        // Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly PublishedDate { get; set; }
        public int Tracks { get; set; } // Antalet låtar på skivan
        public string? Length { get; set; } // Total låtlängd på skiva

        public int ArtistId { get; set; } // ID till artist
        public Artist? Artist { get; set; } 

    }

}